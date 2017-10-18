using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour {
	public bool isDead;
	public float restartTimer;
	public float restartDelay;

	Animator anim;
	float replay;

	void Start()
	{
		isDead = false;
	}

	void Awake () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(isDead == true)
		{
			// ... tell the animator the game is over.
			anim.SetTrigger ("GameOver");

			// .. increment a timer to count up to restarting.
			restartTimer += Time.deltaTime;

			// .. if it reaches the restart delay...
			if(restartTimer >= restartDelay)
			{
				// .. then reload the currently loaded level.
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}
