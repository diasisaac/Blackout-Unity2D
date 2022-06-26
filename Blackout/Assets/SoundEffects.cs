using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour {
	public static SoundEffects Instance;
	public AudioClip jupping;
	public AudioClip running;
	public AudioClip falling;
	public AudioClip hitting;

	// Use this for initialization
	void Awake () {
		if (Instance != null) {
		
			Debug.Log ("Existem multiplas");
		}	
		Instance = this;
	}
	public void JumppingSound(){
	
		MakeSound (jupping);
	
	}
	public void RunningSound(){
		MakeSound (running);
	
	}
	public void FalingSound(){
		
		MakeSound (falling);
	
	}
	public void Hitting(){
	
		MakeSound (hitting);
	}
	public void MakeSound(AudioClip originalClip){
	
		AudioSource.PlayClipAtPoint (originalClip, transform.position);
	
	}
	// Update is called once per frame
	void Update () {
		
	}
}
