using UnityEngine;

public class Event_Custom_Delegate : MonoBehaviour
{
    public delegate void EventDelegate(float f);

    public event EventDelegate OnFloatEvent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(OnFloatEvent != null)
            {
                OnFloatEvent(5.5f);
            }
        }
    }
}
