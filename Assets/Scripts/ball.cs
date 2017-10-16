using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    
	public float speed;

	private Vector3 force;
	private Rigidbody rb;

    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }
    
	IEnumerator ForceRandom()
	{
		
		Debug.Log(Time.time);
		rb.AddForce(Random.Range(0, 10) *  speed, 0.0f, Random.Range(0, 10) *speed, ForceMode.Impulse);
		yield return new WaitForSeconds(5);
		Debug.Log(Time.time);
	}
/*
	void FixedUpdate()
	{
		Debug.Log(Time.time);
		rb.AddForce(Random.Range(0, 10) *  speed, 0.0f, Random.Range(0, 10) *speed, ForceMode.Impulse);
		Debug.Log(Time.time);
	}

*/

}
