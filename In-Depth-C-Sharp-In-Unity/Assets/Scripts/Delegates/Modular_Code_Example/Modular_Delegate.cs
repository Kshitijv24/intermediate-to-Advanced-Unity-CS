using UnityEngine;

public class Modular_Delegate : MonoBehaviour
{
    [SerializeField] private Modular_Timer modular_Timer;

    private void Start()
    {
        modular_Timer.SetTimer(1f, () => Debug.Log("Timer Completed"));

        modular_Timer.SetTimer(1f, MessageDelegate);
    }

    public void MessageDelegate()
    {
        Debug.Log("Timer is Complete");
    }
}
