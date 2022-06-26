using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {
	private Player001 player;

	void Start()
	{
		player = gameObject.GetComponentInParent<Player001> ();
	
	}
	void OnTriggerStay2D(Collider2D col)
	{

		player.grounded = true;
	}
	void OnTriggerExit2D(Collider2D col)
	{
		player.grounded = false;
	}
}
