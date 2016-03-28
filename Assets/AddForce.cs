using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {

    public float hitImpactVelocity;
    public LayerMask mask;
    Ray ray;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void Clicked()
    {
        print("receiveing click");
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, mask))
        {
            if (hit.transform.GetComponent<Rigidbody>())
            {
                hit.transform.GetComponent<Rigidbody>().AddForce(hit.point * hitImpactVelocity);
            }
        }
    }


}
