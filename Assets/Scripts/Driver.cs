using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float _vehicleBaseSpeed = 0.1f;
    [SerializeField] private float _vehicleSteerSpeed = 1f;

    void FixedUpdate()
    {
        float vehicleSpeed = Input.GetAxis("Vertical") * _vehicleBaseSpeed;
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
}
