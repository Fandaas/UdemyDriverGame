public interface ITriggerTarget
{
    TriggerTargetTypes GetTriggerType();
    void HandleTriggerEvent();
}
