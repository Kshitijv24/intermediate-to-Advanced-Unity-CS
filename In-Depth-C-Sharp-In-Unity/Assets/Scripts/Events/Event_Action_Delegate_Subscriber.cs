using UnityEngine;

public class Event_Action_Delegate_Subscriber : MonoBehaviour
{
    private void Start()
    {
        Event_Action_Delegate event_Action_Delegate = GetComponent<Event_Action_Delegate>();
        event_Action_Delegate.OnActionEvent += Event_Action_Delegate_OnActionEvent;
    }

    private void Event_Action_Delegate_OnActionEvent(bool arg1, int arg2)
    {
        Debug.Log(arg1 + " " + arg2);
    }
}
