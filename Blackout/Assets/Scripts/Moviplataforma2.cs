using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moviplataforma2 : MonoBehaviour {
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
		transform.position -= new Vector3 (0, -velBarril, 0) * Time.deltaTime;

	}


}
