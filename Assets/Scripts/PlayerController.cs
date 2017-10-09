using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float tilt;

	void Start () {
        GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody>().position = new Vector3(0.0f, 0.0f, 0.0f);
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(moveVertical * tilt -90, 0.0f, moveHorizontal * tilt);
	}
}
