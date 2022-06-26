using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	Animator anim;
	public Door door;
	//public bool sticks;


	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {




	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("Player") || coll.gameObject.CompareTag ("barril") ) {
			anim.SetBool ("goDown", true);
			door.DoorOpens ();
		}

	}

	void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("Player") || coll.gameObject.CompareTag ("barril") ) {
			//	if (sticks)
			//		return;	
			anim.SetBool ("goDown", false);
			door.DoorCloses ();
		}
	}
}
