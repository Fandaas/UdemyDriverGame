using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DriverManager))]
public class DriverCollisionHandler : MonoBehaviour
{
    private DriverManager _driverManager;
    [SerializeField] private float _collisionSlowdownFactor = -0.3f;

    private void Start()
    {
        _driverManager = GetComponent<DriverManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _driverManager.AdjustSpeed(_collisionSlowdownFactor);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ITriggerTarget target;
        if(collision.TryGetComponent<ITriggerTarget>(out target))
        {
            switch (target.GetTriggerType())
            {
                case TriggerTargetTypes.Booster:
                    if(target is BoosterTarget booster)
                    {
                        _driverManager.AdjustSpeed(booster.GetSpeedModifier());
                    }
                    break;
                case TriggerTargetTypes.Package:
                    if(target is PackageTarget package)
                    {
                        _driverManager.PickupPackage(package);
                        package.HandleTriggerEvent();
                    }
                    break;
                case TriggerTargetTypes.Customer:
                    if (_driverManager.DeliverPackage())
                    {
                        Debug.Log($"Customer package delivered");
                        target.HandleTriggerEvent();
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
