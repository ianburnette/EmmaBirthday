using UnityEngine;
using System.Collections;

public class ShadeHandleScript : MonoBehaviour {

    public bool canChange;
    public float waitTime;
    public bool up;
    public Rigidbody rb;
    public Transform shade;
    public float baseGravAmt;
    public float currentGravAmt;
    public Vector3 offset;

    void Start()
    {
        offset = transform.position - shade.transform.position;
        currentGravAmt = baseGravAmt;
    }

    public void Clicked()
    {
        print("clicked");
        if (canChange)
        {
            up = !up;
            ChangeGrav();
            canChange = false;
            Invoke("EnableChange", waitTime);
        }
    }

    void EnableChange()
    {
        canChange = true;
    }

    void Update()
    {
        transform.position = shade.transform.position + offset;
        rb.AddForce(Vector3.up * currentGravAmt * Time.deltaTime);
    }

    void ChangeGrav()
    {
        if (up)
            currentGravAmt = -baseGravAmt;
        else
            currentGravAmt = baseGravAmt;
    }
}
