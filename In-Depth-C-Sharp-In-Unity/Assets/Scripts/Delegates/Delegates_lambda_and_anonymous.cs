using UnityEngine;

public class Delegates_lambda_and_anonymous : MonoBehaviour
{
    public delegate void TestDelegate();
    private TestDelegate testDelegate;

    public delegate bool BoolDelegate(int i);
    private BoolDelegate boolDelegate;

    private void Start()
    {
        // creating delegate using Anonymous function.

        testDelegate = delegate () { Debug.Log("Anonymous method"); };
        testDelegate();

        // another way of creating delegate using Anonymous in lamda function.

        testDelegate = () => { Debug.Log("Lamda expression"); };
        testDelegate();

        boolDelegate = (int n) => { return n < 5; };

        // more compact way of writing the single statement lamda expression.

        boolDelegate = (int n) => n < 5;

        Debug.Log(boolDelegate(2));

        // Note -> we can not remove a function from delegate that is created using lamda expression.
        // because we do not have a unique refrance for that function.

        testDelegate = () => { Debug.Log("Lamda expression"); };
        testDelegate += () => { Debug.Log("Second Lamda Expression"); };
        testDelegate();
    }
}
