using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoviBarril : MonoBehaviour {
	public float velBarril;
	public float tempoVida;

	void OnEnable()
	{
		Invoke ("Desligar", tempoVida);

	}

	void Desligar()
	{
		gameObject.SetActive (false);

	}

	void OnDisable()
	{
		CancelInvoke ();

	}
	void Update()
	{
		transform.position -= new Vector3 (0, velBarril, 0) * Time.deltaTime;

	}

	void OnTriggerEnter2D( Collider2D coll){

		if( coll.tag == ("Player")){
				

			SceneManager.LoadScene ("inicio");


		}

	}	

}

