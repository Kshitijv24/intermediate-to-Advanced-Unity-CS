using UnityEngine;

public class Multicast_Delegates : MonoBehaviour
{
    private delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;

    private void Start()
    {
        myMultiDelegate = Sphere;
        // here we are multicasting the delegate using +=
        myMultiDelegate += Sphere_Turning_Red;
        myMultiDelegate();

        // removing an function from delegate using -=
        myMultiDelegate -= Sphere_Turning_Red;
        myMultiDelegate -= Sphere;

        // we should never call a delegate before assigning any function to it
        // otherwise it will gonna have null value by default which will give us null value exception.

        // so as a safety mechanism we can check before calling a delegate if it is null or not

        if(myMultiDelegate != null)
        {
            myMultiDelegate();
        }
    }

    private void Sphere()
    {
        print("this is a Sphere");
    }
    
    private void Sphere_Turning_Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
        print("now Sphere is Red");
    }
}
