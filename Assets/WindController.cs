using UnityEngine;
using System.Collections;

public class WindController : MonoBehaviour {

    public float zRange, yRange;
    public GameObject wind;
    public float repeatTime;

    void OnEnable()
    {
        CancelInvoke();
        InvokeRepeating("NewWind", 0, repeatTime);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void NewWind()
    {
        GameObject windy = (GameObject)Instantiate(wind, new Vector3(transform.position.x, 
            transform.position.y + Random.Range(-yRange, yRange), 
            transform.position.z + Random.Range(-zRange, zRange)), Quaternion.identity);
    }
}
