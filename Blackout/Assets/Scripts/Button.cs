using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour {
	
	// Use this for initialization
	public void MudarCenario (string scene) {
		SceneManager.LoadScene (scene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
