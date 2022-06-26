using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlataform : MonoBehaviour {
	private Rigidbody2D rb2d;
	public float FallDelay;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

		}
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.collider.CompareTag ("Player")) {
			StartCoroutine (Fall ());
		}
	}
		IEnumerator Fall()
		{
		yield return new WaitForSeconds (FallDelay);
				rb2d.isKinematic = false;

			yield return 0;
		}
	}