using UnityEngine;

public class Non_Modular_Timer : MonoBehaviour
{
    private float timer;
    
    public void SetTimer(float timer)
    {
        this.timer = timer;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
    }

    public bool IsTimerComplete()
    {
        return timer <= 0f;
    }
}
