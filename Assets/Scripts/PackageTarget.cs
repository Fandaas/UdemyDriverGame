using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageTarget : MonoBehaviour, ITriggerTarget
{
    [SerializeField] private Transform _packageSpawnpoint;
    [SerializeField] private TriggerTargetTypes _triggerTargetType = TriggerTargetTypes.Package;
    public TriggerTargetTypes GetTriggerType() { return _triggerTargetType; }

    public void HandleTriggerEvent()
    {
        Despawn();
    }

    private void Despawn()
    {
        this.gameObject.SetActive(false);
    }

    public void Respawn()
    {
        transform.position = _packageSpawnpoint.position;
        this.gameObject.SetActive(true);
    }
}