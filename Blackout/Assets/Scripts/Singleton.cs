using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour {


	public Player001 player;
	private static Singleton instance;

	// Use this for initialization
	public static Singleton GetIntance()
	{
		if (instance == null) {
			instance = GameObject.FindObjectOfType<Singleton> ();

		}
		return instance;
	}
}
