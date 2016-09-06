using UnityEngine;
using System.Collections;

public class Emition : MonoBehaviour {
	// Use this for initialization
	ParticleSystem ps;
	ParticleSystem.EmissionModule em;
	void Start () {
		ps = GetComponent <ParticleSystem> ();
		em = ps.emission;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space))
		{
			em.enabled = true;
		}
		else
		{
			em.enabled = false;
			
		}
	}
}
