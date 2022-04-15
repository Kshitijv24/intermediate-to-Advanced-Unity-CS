using UnityEngine;
using System;

public class Event_Action_Delegate : MonoBehaviour
{
    public event Action<bool, int> OnActionEvent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(OnActionEvent != null)
            {
                OnActionEvent(true, 50);
            }
        }
    }
}
