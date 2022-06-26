using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

	[SerializeField]
	GameObject[] switches = null;

	[SerializeField]
	GameObject exitDoor = null;

	int noOfSwitches = 0;

	[SerializeField]
	Text switchCount = null;


	// Use this for initialization
	void Start () {
		GetNoOfSwitches ();
	}
	
	// Update is called once per frame

	public int GetNoOfSwitches(){
	
		int x = 0;

		for (int i = 0; i < switches.Length; i++) {
		
			if (switches [i].GetComponent<Switchlevel> ().isOn == false) {
				x++;
			} else if (switches [i].GetComponent<Switchlevel> ().isOn == true) {
				noOfSwitches--;
			}
	
		}

		noOfSwitches = x;
		return noOfSwitches;	
	}
	public void GetExitDoorState(){
	
		if (noOfSwitches <= 0) {
		
			exitDoor.GetComponent<Door> ().DoorOpens ();
			Debug.Log ("zero");
		}
	
	}
	void Update () {
		switchCount.text = GetNoOfSwitches ().ToString ();
		GetExitDoorState ();
	}

}
