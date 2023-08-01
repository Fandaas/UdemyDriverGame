using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DriverManager))]
public class DriverCollisionHandler : MonoBehaviour
{
    private DriverManager _driverManager;

    private void Start()
    {
        _driverManager = GetComponent<DriverManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log($"DriverCollisionHandler >> Kolize s {collision.gameObject.name}");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TriggerTarget target;
        if(collision.TryGetComponent<TriggerTarget>(out target))
        {
            switch (target.GetTriggerType())
            {
                case TriggerTargetTypes.Booster:
                    break;
                case TriggerTargetTypes.Package:
                    if (_driverManager.PickupPackage())
                    {
                        Debug.Log($"Package collected");
                        collision.gameObject.SetActive(false);
                    }
                    break;
                case TriggerTargetTypes.Customer:
                    if (_driverManager.DeliverPackage())
                    {
                        Debug.Log($"Customer package delivered");
                        collision.gameObject.SetActive(false);
                    }
                    break;
                case TriggerTargetTypes.Slowdown:
                    break;
                default:
                    break;
            }
        } else
        {
            Debug.Log($"DriverCollisionHandler >> Trigger objekt {collision.gameObject.name} nemá TriggerTarget komponent");
        }       
    }
}
