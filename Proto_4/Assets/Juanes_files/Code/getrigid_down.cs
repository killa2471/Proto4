using UnityEngine;
using System.Collections;

public class getrigid_down : MonoBehaviour {
	HingeJoint hindge;
	// Use this for initialization
	void Start () {
		hindge = GetComponent<HingeJoint> ();
		hindge.connectedBody = transform.GetChild(0).gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
