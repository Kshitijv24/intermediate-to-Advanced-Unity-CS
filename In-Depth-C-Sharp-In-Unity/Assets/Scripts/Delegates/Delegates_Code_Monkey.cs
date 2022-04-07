using UnityEngine;

public class Delegates_Code_Monkey : MonoBehaviour
{
    public delegate bool BoolDelegate(int i);
    BoolDelegate boolDelegate;

    private void Start()
    {
        boolDelegate = BoolFunction;
        Debug.Log(boolDelegate(1));

        // another way of defining the delegate
        // explicitly creating delegate

        boolDelegate = new BoolDelegate(BoolFunction);
        Debug.Log(boolDelegate(2));
    }

    public bool BoolFunction(int n)
    {
        return n < 5;
    }
}
