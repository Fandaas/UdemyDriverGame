using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float _vehicleBaseSpeed = 0.1f;

    void FixedUpdate()
    {
        transform.Translate(0, _vehicleBaseSpeed, 0);
    }
}
