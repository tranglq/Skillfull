using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGDscroll : MonoBehaviour {

	public float speedScroll;
	public float tilt;
	public GameOverController GOverContrl;

	private Vector3 startPosition;

	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float newPosition = Mathf.Repeat (Time.time * speedScroll, tilt);
		transform.position = startPosition - newPosition * Vector3.forward;
	}

	void OnTriggerEnter(Collision other)
	{
		Destroy (other.gameObject);
		GOverContrl.isDead = true;
	}
}
