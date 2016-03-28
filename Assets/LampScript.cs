using UnityEngine;
using System.Collections;

public class LampScript : MonoBehaviour {

    public bool on;
    public Material onMaterial, offMaterial;
    public Renderer thisRenderer;
    public Texture emissionMap, emissionMapOff;
    public Light lightInstance;

	// Use this for initialization
	void Start () {
        thisRenderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Clicked()
    {
        if (on)
        {
            on = false;
            thisRenderer.material.SetTexture("_EmissionMap", emissionMapOff);
            lightInstance.enabled = false;
        }
        else
        {
            on = true;
            thisRenderer.material.SetTexture("_EmissionMap", emissionMap);
            lightInstance.enabled = true;
        }
    }
}
