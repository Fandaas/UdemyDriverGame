using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverCollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"DriverCollisionHandler >> Kolize s {collision.gameObject.name}");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"DriverCollisionHandler >> Trigger s {collision.gameObject.name}");
    }
}
