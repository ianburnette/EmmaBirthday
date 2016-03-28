using UnityEngine;
using System.Collections;

public class TriggerAnimation : MonoBehaviour {

    public Animator anim;
    public string triggerToCall;

	// Use this for initialization
	void Start () {
	    if (!anim){
            anim = GetComponent<Animator>();
        }
	}

    public void Clicked()
    {
        anim.SetTrigger(triggerToCall);
    }
}
