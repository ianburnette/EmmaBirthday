using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SetupJoint : MonoBehaviour {

	void OnEnable () {
        GetComponent<CharacterJoint>().connectedBody = transform.parent.GetComponent<Rigidbody>();
	}
}
