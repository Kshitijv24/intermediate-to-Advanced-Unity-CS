using UnityEngine;
using System;

public class Built_In_Delegates : MonoBehaviour
{
    // there are are some built-in delegates in System namespace in unity.

    // this is a delegate that returns void and take no parameters.
    private Action action;

    // this is a delegate that take generic parameters of any kind.
    private Action<int, float> genericAction;

    // this is a delegate that will take generic parameters and return an data type.
    private Func<int, bool> funcDelegate;

    private void Start()
    {
        genericAction = (int i, float f) => { Debug.Log("Generic Delegate Action called by a Lamda Expression"); };
        genericAction(5, 0.2f);

        genericAction = GenericDelegate;
        genericAction(3, 2.4f);

        funcDelegate = (int i) => { return i < 5; };
        Debug.Log("Using Lamda Expression = " + FuncDelegate(3));

        funcDelegate = FuncDelegate;
        Debug.Log(FuncDelegate(2));

    }

    private void GenericDelegate(int i, float f)
    {
        Debug.Log("Generic Delegate Action called by a non-Lamda Expression");
    }

    private bool FuncDelegate(int i)
    {
        return (i < 5);
    }

}
