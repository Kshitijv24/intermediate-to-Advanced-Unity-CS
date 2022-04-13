using UnityEngine;
using System;

public class Events_Script_Without_Explanation : MonoBehaviour
{
    public event EventHandler OnSpacePressed;

    private void Start()
    {
        OnSpacePressed += OnSpacePressed_Event;
    }

    public void OnSpacePressed_Event(object o, EventArgs e)
    {
        Debug.Log("Space is Pressed");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(OnSpacePressed != null)
            {
                OnSpacePressed(this, EventArgs.Empty);
            }
        }
    }
}
