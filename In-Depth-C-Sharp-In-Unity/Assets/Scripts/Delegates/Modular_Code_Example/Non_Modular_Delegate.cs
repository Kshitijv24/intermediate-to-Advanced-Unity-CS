using UnityEngine;

public class Non_Modular_Delegate : MonoBehaviour
{
    [SerializeField] private Non_Modular_Timer timer;

    private bool hasTimerElapsed = false;

    private void Start()
    {
        timer.SetTimer(1f);
    }

    private void Update()
    {
        if (!hasTimerElapsed && timer.IsTimerComplete())
        {
            Debug.Log("Timer Complete");
            hasTimerElapsed = true;
        }
    }
}
