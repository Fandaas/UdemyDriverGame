using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float _vehicleBaseSpeed = 0.1f;
    [SerializeField] private float _vehicleSteerSpeed = 1f;
    [SerializeField] private float _maxSpeedModifier = 2.3f;
    [SerializeField] private float _minSpeedModifier = 0.9f;
    private float _speedModifier = 1f;

    void FixedUpdate()
    {
        float vehicleSpeed = Input.GetAxis("Vertical") * _vehicleBaseSpeed * _speedModifier;
        float vehicleSteerSpeed = 0f;
        if (vehicleSpeed != 0) {
            vehicleSteerSpeed = Input.GetAxis("Horizontal") * _vehicleSteerSpeed;
        } 
        transform.Translate(0, vehicleSpeed, 0);
        if(vehicleSpeed < 0)
        {
            vehicleSteerSpeed = vehicleSteerSpeed * -1;
        }
        transform.Rotate(0,0, -vehicleSteerSpeed);
    }

    public void SetSpeedModifier(float speedModifierAmount)
    {
        float speedModifier = _speedModifier + speedModifierAmount;
        if (speedModifier < _minSpeedModifier) speedModifier = _minSpeedModifier; 
        _speedModifier = Mathf.Min(speedModifier, _maxSpeedModifier);     
    }
}
