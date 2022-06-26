using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCloud : MonoBehaviour {

	public GameObject cloudprefab; // objeto spawnado
	public float rateSpawn;
	public float currentTime;
	// Use this for initialization
	void Start () {
		currentTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;

		transform.Translate (Vector2.right * Time.deltaTime);


		transform.Translate ( Vector2.right * currentTime);

	}
}
