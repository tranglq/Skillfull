using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;

    private Rigidbody rb;


	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveVertical*speed, moveHorizontal*speed, 0.0f);
        rb.rotation = Quaternion.Euler(movement);
	}
}
