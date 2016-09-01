using UnityEngine;
using System.Collections;

public class MoveBalloon : MonoBehaviour {

    public float currentTemp;
    public float currentMass;
    public float currentFuel = 1000;
    public float currentHeight;
    public float heightToReach;

	// Use this for initialization
	void Start () {
        currentTemp = 0.1f;
        currentMass = 20.0f;
	}

    float GetYChange()
    {
        //Fuel is being used. 
        if (Input.GetKey(KeyCode.Space))
        {
            currentFuel -= 0.1f;
            if (currentTemp < 100)
                currentTemp += 0.4f;
        }
        else if (Input.GetKey(KeyCode.LeftAlt))
        {
            if (currentTemp > -10.0)
                currentTemp -= 0.4f;
        }
        else
        {
            currentTemp -= 0.1f;
        }
        return currentTemp / (currentMass * 2);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveY = GetYChange();

        Vector3 movement = new Vector3(0.0f, moveY, 0.0f);
        Debug.Log(moveY);
        if(!(transform.position.y <= 0 && currentTemp <= 0.0f))
        transform.position = new Vector3(transform.position.x, transform.position.y + moveY, transform.position.z);
    }
   
	// Update is called once per frame
	void Update () {
	
	}
}
