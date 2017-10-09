using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    private float speed;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>();
        GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>();
        GetComponent<Collider>();
    }
}
