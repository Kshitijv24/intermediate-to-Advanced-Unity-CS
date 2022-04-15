using UnityEngine;

public class Event_Custom_Delegate_Subscirber : MonoBehaviour
{
    private void Start()
    {
        Event_Custom_Delegate event_Custom_Delegate = GetComponent<Event_Custom_Delegate>();
        event_Custom_Delegate.OnFloatEvent += Event_Custom_Delegate_OnFloatEvent;
    }

    private void Event_Custom_Delegate_OnFloatEvent(float f)
    {
        Debug.Log("float " + f);
    }
}
