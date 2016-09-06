using UnityEngine;
using System.Collections;

public class Move_sphere : MonoBehaviour {
	Rigidbody rigid;
    public float floating = 10f;

    // Use this for initialization
    void Start () {
		rigid = GetComponent<Rigidbody> ();
      

	}
	
   


	// Update is called once per frame
	void FixedUpdate ()
	{
        if (Input.GetKey(KeyCode.Space))
        {
            floating += 5f * Time.deltaTime;
        }
        else if(floating > 0)
        {
			floating -= 2.5f * Time.deltaTime; 
        }


            Vector3 movement = new Vector3 (0f, floating, 0f);
        Debug.Log(movement);

		rigid.AddForce(movement);
}
}
