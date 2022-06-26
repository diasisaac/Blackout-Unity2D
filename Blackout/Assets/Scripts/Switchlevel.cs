using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchlevel : MonoBehaviour {

	[SerializeField]
	GameObject switchOn = null;

	[SerializeField]
	GameObject switchOff = null;

	public bool isOn = false;
	// Use this for initialization
	void Start () {
		// set the swhitch to off sprite
		gameObject.GetComponent<SpriteRenderer> ().sprite = switchOff.GetComponent<SpriteRenderer> ().sprite;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D coll){
		// set the switch to on sprite
		gameObject.GetComponent<SpriteRenderer> ().sprite = switchOn.GetComponent<SpriteRenderer> ().sprite;
		// set the isOn to true when Triggred
		isOn = true;

	}
}
