using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform vehicleTransform;
    [SerializeField] private float cameraOffsetZ = -10f;
    void LateUpdate()
    {
        transform.position = new Vector3(vehicleTransform.position.x, vehicleTransform.position.y, cameraOffsetZ);
    }
}
