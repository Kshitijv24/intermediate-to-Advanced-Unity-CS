using UnityEngine;

public class Delegates_Unity : MonoBehaviour
{
    // declaring delegate Template.
    private delegate void MyDelegate(int n);
    // declaring member variable.
    MyDelegate myDelegate;

    // all the functions must have the same signature as delegate to be used in delegate.

    private void Start()
    {
        // assigning the PrintNum Function in myDelegate.
        myDelegate = PrintNum;
        // using myDelegate as a Function.
        myDelegate(50);

        // assigning the DoubleNum Function in myDelegate.
        myDelegate = DoubleNum;
        // using myDelegate as a Function.
        myDelegate(50);
    }

    private void PrintNum(int num)
    {
        Debug.Log("Print Num: " + num);
    }

    private void DoubleNum(int num)
    {
        Debug.Log("Double Num: " + num * 2);
    }

}
