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
        TriggerTarget target;
        if(collision.TryGetComponent<TriggerTarget>(out target))
        {
            switch (target.GetTriggerType())
            {
                case TriggerTargetTypes.Booster:
                    break;
                case TriggerTargetTypes.Package:
                    Debug.Log($"Package collected");
                    break;
                case TriggerTargetTypes.Customer:
                    Debug.Log($"Customer roadkill");
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
