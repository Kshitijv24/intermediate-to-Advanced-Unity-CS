using UnityEngine;
using System;

public class Event_Subscriber : MonoBehaviour
{
    private void Start()
    {
        Event_Publisher event_Publisher = GetComponent<Event_Publisher>();

        event_Publisher.OnSpacePressed += Event_Space_Button_Subscriber_Message;
        event_Publisher.OnSpacePressed += Event_Left_Shift_Button_Subscriber_Message;

        event_Publisher.OnShiftPressed += Event_Left_Shift_Button_Subscriber_Message;
    }

    private void Event_Space_Button_Subscriber_Message(object sender, EventArgs eventArgs)
    {
        Debug.Log("Space Button is Pressed");
    }

    private void Event_Left_Shift_Button_Subscriber_Message(object sender, EventArgs eventArgs)
    {
        Debug.Log("Left Shift Button is Pressed");
    }
}
