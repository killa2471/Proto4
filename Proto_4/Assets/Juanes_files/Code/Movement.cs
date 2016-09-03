using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    Rigidbody rigid;
    public float Speed;


    // Use this for initialization
    void Start()
    {

        rigid = GetComponent<Rigidbody>();


    }




    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * Speed;
        float moveVertical = Input.GetAxis("Vertical") * Speed;

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        Debug.Log(movement);

        rigid.AddForce(movement);
    }
}
