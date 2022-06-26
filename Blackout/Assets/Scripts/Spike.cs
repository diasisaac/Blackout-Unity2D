using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour {
	private Player001 player;
		
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player001>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D coll){
//		if(coll.CompareTag("Player")){
//			StartCoroutine (player.KnockBack (0.2f, 350, player.transform.position));
//			Debug.Log ("Ai");
//
//		}

		if (coll.gameObject.CompareTag ("Player")) {
			Rigidbody2D rb = coll.gameObject.GetComponent<Rigidbody2D> ();

			if (coll.gameObject.transform.localScale.x > 0) {
				
				rb.AddForce (new Vector2 (-500f,500f));
			} else {
				
				rb.AddForce (new Vector2 (500f,500f));
			}
		}
		if(coll.gameObject.CompareTag("espinho")){

			Destroy(gameObject);

		}
	}
}
