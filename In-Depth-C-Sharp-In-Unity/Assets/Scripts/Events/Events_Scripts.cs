using UnityEngine;
using System;

public class Events_Scripts : MonoBehaviour
{
    // template of an Event, in witch EventHandler is a Delegate.
    public event EventHandler OnSpacePressed;

    private void Start()
    {
        // Subscribing to the Event

        OnSpacePressed += Function_OnSpacePressed;
        //OnSpacePressed(this, EventArgs.Empty);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //if (OnSpacePressed != null)
            //{
            //    Event being fired
            //    Calling the event Delegate to start the Event

            //    OnSpacePressed(this, EventArgs.Empty);
            //}

            // C# 6.0 Shorthand Version of Checking if not null

            //    Event being fired
            //    Calling the event Delegate to start the Event

            //OnSpacePressed?.Invoke(this, EventArgs.Empty);
        }
    }

    // In Order to Subscribe to the event first we need to Define a Function that will reseve that Event.

    // Function Signature needs to be same as the Event.

    private void Function_OnSpacePressed(object sender, EventArgs e)
    {
        Debug.Log("Space is Pressed");
    }
}
