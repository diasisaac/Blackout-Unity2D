using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarrilPooling : MonoBehaviour {

	public float fireInicial;
	public float fireContinuo;
	public GameObject Barril;

	public int numeroBarril;
	List<GameObject>listaBarril;

	void Start()
	{
		listaBarril = new List<GameObject>();

		for (int i = 0; i < numeroBarril; i++)
		{
			GameObject obj = (GameObject)Instantiate(Barril);
			obj.SetActive (false);
			listaBarril.Add (obj);
		}

		InvokeRepeating ("Fire", fireInicial, fireContinuo);
	}
	void OnTriggerEnter2D( Collider2D coll){

		if( coll.tag == ("Player")){


			SceneManager.LoadScene ("inicio");


		}

	}	
	void Fire()
	{
		for (int i = 0; i < listaBarril.Count; i++) 
		{
			if (!listaBarril[i].activeInHierarchy)
			{
				listaBarril[i].transform.position = transform.position;
				listaBarril[i].transform.rotation = transform.rotation;
				listaBarril[i].SetActive (true);
				break;
			}
		}
	}

}
