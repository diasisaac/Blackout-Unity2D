using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorcegoIA : MonoBehaviour {
	public Transform batHome;
	public Transform player;
	private Vector3 positionPlayerLost;
	private Vector3 positionPlayerFind;
	private Transform bat;
	//public Player001 playeer;
	public float speed ; //heightAdjust
	private float startTime;
	private float journeyLength;

	public bool lostPlayer = true;
	public bool canFly = false;

	void Start () {
		//Player001 playeercopy = Instantiate<Player001> (playeer);

		bat = GetComponent<Transform> ();

		batHome = bat.transform.parent;
	
		player = GameObject.FindGameObjectWithTag ("Player").transform;

		positionPlayerLost = batHome.position;

		BackToHome ();
	}

	// Update is called once per frame
	void Update ()
	{
//		if (playeer.isHiding) {
//		
//			BackToHome ();
//		}
//
	 if (canFly) 
			if (lostPlayer) 
			{
				float dist = (Time.time - startTime) * speed;
				float journey = dist / journeyLength;

				if (bat.position == batHome.position)
					canFly = false;
			
			bat.position = Vector3.Lerp (positionPlayerLost, batHome.position,journey);
				
			}
		else 
		{
			bat.position = Vector3.Lerp (bat.position, player.transform.position, 0.03f);
		}

	}

	public void FollowPlayer() {
		Vector3 target = player.transform.position;
		target.y += speed;
		transform.position = Vector3.MoveTowards (transform.position, target, Time.deltaTime * speed); 

	}

	public void BackToHome(){

		startTime = Time.time;
		positionPlayerLost = bat.position;
		journeyLength = Vector3.Distance (positionPlayerLost, batHome.position);

	}
	void OnTriggerEnter2D( Collider2D coll){

		if( coll.tag == ("Player")){

			lostPlayer = false;
			BackToHome ();

		}

	
	}


}
