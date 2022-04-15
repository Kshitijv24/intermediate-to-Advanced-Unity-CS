using UnityEngine;
using System;
using UnityEngine.Events;

public class UnityEvents : MonoBehaviour
{
    public UnityEvent OnUnityEvent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnUnityEvent?.Invoke();
        }
    }
}
