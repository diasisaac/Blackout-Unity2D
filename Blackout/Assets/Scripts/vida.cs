using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class vida : MonoBehaviour {
	public float vidaplayer;
	public GameObject coraçãooff;
	public GameObject coraçãooff_1;
	public GameObject coraçãooff_2;

	// Use this for initialization
	void Start () {
		vidaplayer = 3;
		coraçãooff.SetActive (false);
		coraçãooff_1.SetActive (false);
		coraçãooff_2.SetActive (false);
		
	}
		private void OnCollisionEnter2D(Collision2D coll)
		{
			if (coll.gameObject.CompareTag("espinho"))
			{
				vidaplayer--;
				if (vidaplayer == 2) {
					coraçãooff.SetActive (true);
				}
				if (vidaplayer == 1) {
					coraçãooff_1.SetActive (true);
				}
				if (vidaplayer == 0) {
					coraçãooff_2.SetActive (true);
				}
			}
		
	}
	// Update is called once per frame
	void Update () {
		
	}
}
