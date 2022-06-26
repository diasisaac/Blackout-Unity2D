using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> (); 
		DoorCloses ();
	}
	// Update is called once per frame
	void Update () {
		
	}
	public void DoorOpens()
	{
		anim.SetBool ("IsOpen", false);
		Debug.Log ("abrindo");
	}
	public void DoorCloses()
	{
		anim.SetBool ("IsOpen", true);
	}
	void CollEnable()
	{
		GetComponent<Collider2D>().enabled = true;
	}
	void CollDisable()
	{
		GetComponent<Collider2D>().enabled = false;
	}
}
