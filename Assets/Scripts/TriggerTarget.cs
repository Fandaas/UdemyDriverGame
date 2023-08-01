using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTarget : MonoBehaviour
{
    [SerializeField] private TriggerTargetTypes _triggerObjectType;

    public TriggerTargetTypes GetTriggerType() { return _triggerObjectType; }
}
