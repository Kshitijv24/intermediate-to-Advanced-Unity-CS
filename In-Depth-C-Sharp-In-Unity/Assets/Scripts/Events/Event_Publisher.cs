using UnityEngine;
using System;

public class Event_Publisher : MonoBehaviour
{
    public event EventHandler OnSpacePressed;
    public event EventHandler OnShiftPressed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(OnSpacePressed != null)
            {
                OnSpacePressed(this, EventArgs.Empty);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if(OnShiftPressed != null)
            {
                OnShiftPressed(this, EventArgs.Empty);
            }
        }
    }
}
