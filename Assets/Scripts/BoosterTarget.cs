using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterTarget : MonoBehaviour, ITriggerTarget
{
    [SerializeField] private TriggerTargetTypes _triggerTargetType = TriggerTargetTypes.Booster;
    [SerializeField] private float _boosterSpeedModifier = 0.2f;
    public TriggerTargetTypes GetTriggerType() { return _triggerTargetType; }

    public void HandleTriggerEvent()
    {

    }

    public float GetSpeedModifier()
    {
        return _boosterSpeedModifier;
    }
}
