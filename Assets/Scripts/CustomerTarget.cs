using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class CustomerTarget : MonoBehaviour, ITriggerTarget
{
    [SerializeField] private TriggerTargetTypes _triggerTargetType = TriggerTargetTypes.Customer;
    [SerializeField] private List<Transform> _spawnpoints;
    public TriggerTargetTypes GetTriggerType() { return _triggerTargetType; }

    private void Start()
    {
        Respawn();
    }

    public void HandleTriggerEvent()
    {
        this.gameObject.SetActive(false);
        Respawn();
    }

    private void Respawn()
    {
        int spawnIndex = Random.Range(0, _spawnpoints.Count -1);
        transform.position = _spawnpoints[spawnIndex].position;
        this.gameObject.SetActive(true);
    }
}