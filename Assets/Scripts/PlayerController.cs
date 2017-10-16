using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float tilt;
    public float thrust;

    void Start () {
        GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody>().position = new Vector3(0.0f, 0.0f, 0.0f);
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(moveVertical * tilt, 0.0f, - moveHorizontal * tilt);
	}

}
