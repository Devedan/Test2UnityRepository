using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movespeed = 2f;  // Use this for initialization
    // Rigidbody thisRigidbody;
    private Vector3 input;
    void Start () {
        print("Starting");
        //thisRigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		input = new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime, 0.0f, Input.GetAxis("Vertical")*Time.deltaTime);
        //print(input);
	//	thisRigidbody.AddForce (input * movespeed); // Ne fonctionne pas pour l'instant...

		transform.Translate(movespeed * input);
    }
}
