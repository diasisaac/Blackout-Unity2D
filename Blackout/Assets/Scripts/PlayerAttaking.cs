using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttaking : MonoBehaviour {
	private bool attaking = false;
	private float attackTimer = 0;
	private float attackCd = 0.3f;

	public Collider2D attackTrigger;

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		attackTrigger.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("left ctrl") && !attaking) {
			EnableAttack ();
		}

//		if (Input.GetKeyDown("left ctrl") && !attaking) {
//			EnableAttack ();
//			//Destroy (gameObject.CompareTag ("barril"));
//			Debug.Log ("Trigger");
//
//		}
//		if (attaking) {
//		
//			if (attackTimer > 0) {
//			
//				attackTimer -= Time.deltaTime;
//			} else {
//			
//				attaking = false;
//				attackTrigger.enabled = false;
//			
//			}
//			anim.SetBool ("Attaking", attaking);
//		}
	}

	public void DisableAttack() {
		attaking = false;
		attackTrigger.enabled = false;
		anim.SetBool ("Attaking", false);
		Debug.Log ("fim do ataque");
	}

	public void EnableAttack() {
		attaking = true;
		attackTimer = attackCd;
		attackTrigger.enabled = true;
		anim.SetBool ("Attaking", attaking);
	}// fechando o enableAttack



		void OnTriggerEnter2D(Collider2D coll)
		{
 			if (coll.gameObject.CompareTag ("barril") || coll.gameObject.CompareTag ("Enemy")) {
				Destroy(coll.gameObject);
			}
//					if (Input.GetKeyDown ("left ctrl") && coll.gameObject.CompareTag("barril")) {
//			
//
//							Destroy(gameObject);	
//						
//						
//					
//					}
				
					
		}//fechando o trigger
			
}


