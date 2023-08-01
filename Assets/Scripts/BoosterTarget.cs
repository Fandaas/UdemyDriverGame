using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterTarget : MonoBehaviour
{
    [SerializeField] private TriggerTargetTypes _triggerTargetType = TriggerTargetTypes.Customer;
    public TriggerTargetTypes GetTriggerType() { return _triggerTargetType; }

    public void HandleTriggerEvent()
    {
       
    }
}
