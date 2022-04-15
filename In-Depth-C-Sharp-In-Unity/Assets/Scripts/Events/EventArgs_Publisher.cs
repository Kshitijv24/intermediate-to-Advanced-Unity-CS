using UnityEngine;
using System;

public class EventArgs_Publisher : MonoBehaviour
{
    // EventHandler has two fields(parameters) one is object and another is EventArgs
    // EventArgs is a Standered way to passing more information through the event
    // here is a example of that

    // first we create an class that will derive from EventArgs class
    public class OnSpacePressedEventArgs : EventArgs
    {
        // and here we define what fields(parameters) we want
        // so what ever we add there need to be given as a parameters whenever we call this Event

        public int spaceCount_In_EventArgs_Class;
    }

    // here we need to pass that event class that we created as Generic.

    public event EventHandler<OnSpacePressedEventArgs> OnSpacePressed;

    private int spaceCount;

    // now our Event will contain an object of OnSpacePressedEventArgs type on the second Parameter.

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceCount++;
            
            if(OnSpacePressed != null)
            {
                OnSpacePressed(this, new OnSpacePressedEventArgs { spaceCount_In_EventArgs_Class = spaceCount });
            }
        }
    }
}
