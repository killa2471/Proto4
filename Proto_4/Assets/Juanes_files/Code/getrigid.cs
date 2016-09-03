using UnityEngine;
using System.Collections;

public class getrigid : MonoBehaviour {
	HingeJoint hindge;
	// Use this for initialization
	void Start () {
		hindge = GetComponent<HingeJoint> ();
		hindge.connectedBody = transform.parent.gameObject.GetComponent<Rigidbody> ();
	}
}
