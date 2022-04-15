using UnityEngine;
using System;

public class EventArga_Subscriber : MonoBehaviour
{
    private void Start()
    {
        EventArgs_Publisher eventArgs_Publisher = GetComponent<EventArgs_Publisher>();
        eventArgs_Publisher.OnSpacePressed += EventArgs_Subscriber_OnSpacePressed;
    }

    private void EventArgs_Subscriber_OnSpacePressed(object sender, EventArgs_Publisher.OnSpacePressedEventArgs e)
    {
        Debug.Log("Space is Pressed " + e.spaceCount_In_EventArgs_Class + " times");
    }
}
