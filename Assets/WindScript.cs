using UnityEngine;
using System.Collections;

public class WindScript : MonoBehaviour {

    public float horizontalSpeed, verticalSpeed, switchTimeMin, switchTimeMax;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        Invoke("ChangeDirection", Random.Range(switchTimeMin, switchTimeMax));
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(Vector3.right * horizontalSpeed * Time.deltaTime);
        rb.AddForce(Vector3.up * verticalSpeed * Time.deltaTime);
	}

    void ChangeDirection()
    {
        verticalSpeed = -verticalSpeed;
        Invoke("ChangeDirection", Random.Range(switchTimeMin, switchTimeMax));
    }
}
