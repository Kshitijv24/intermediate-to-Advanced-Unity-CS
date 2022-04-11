using UnityEngine;
using System;

public class Modular_Timer : MonoBehaviour
{
    private Action message;
    private float timer;

    public void SetTimer(float timer, Action message)
    {
        this.timer = timer;
        this.message = message;
    }

    private void Update()
    {
        if(timer > 0f)
        {
            timer -= Time.deltaTime;

            if (IsTimerComplete())
            {
                message();
            }
        }
    }

    public bool IsTimerComplete()
    {
        return timer <= 0f;
    }
}
