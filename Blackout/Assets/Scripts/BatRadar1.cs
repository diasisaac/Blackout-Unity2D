	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatRadar1 : MonoBehaviour {
	private MorcegoIA script; 


	void Start () {
		script = (MorcegoIA)GetComponentInParent (typeof(MorcegoIA));
		//(Morcego)GetComponentsInParent (typeof (Morcego)); 
	}



	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Player") {
		  script.lostPlayer = false;
			script.canFly = true;
			Debug.Log ("radar seguindo");
			//script.player = col.gameObject.transform;

		}

	}
	void OnTriggerExit2D (Collider2D col) 
	{

		if (col.tag == "Player") 
		{
			
			script.BackToHome ();
			script.lostPlayer = true;
			script.canFly = true;


			//script.player = null;
	
		}

	}
}
