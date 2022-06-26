//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class PoolManeger : MonoBehaviour {
//
//	public Transform northwest;
//	public Transform southeast;
//
//	public GameObject prefab;
//	public int poolSize = 5;
//	private List<GameObject> deactiveObjs;
//	private List<GameObject> activeObjs;
//
//	void Awake()
//	{
//		deactiveObjs = new List<GameObject> ();
//		activeObjs = new List<GameObject> ();
//	}
//
//	// Use this for initialization
//	void Start () {
//		while (deactiveObjs.Count < poolSize) {
//			CreateNewObject ();
//		}
//	}
//	// Update is called once per frame
//	public GameObject Spawn(){
//		if (deactiveObjs.Count == 0) {
//			CreateNewObject ();
//		}
//		GameObject go = deactiveObjs [0];
//		deactiveObjs.RemoveAt (0);
//		activeObjs.Add (go);
//		go.SetActive(true);
//		float x = Random.Range (northwest.position.x,southeast.position.x);
//		float y = Random.Range (northwest.position.y,southeast.position.y);
//		go.transform.position=new Vector3 (x,y,0);
//		return go;
//	}
//	public void StoreObject(GameObject go){
//		StartCoroutine (StoreObject (go));
//
//	}
//	IEnumerator StoreObjectCR(GameObject go ){
//		yield return new waltForEndOfFrame ();
//		go.SetActive (false);
//		activeObjs.Remove (go);
//		deactiveObjs.Add (go);
//	}
//	private void CrateNewOgbect (){
//		GameObject go = TreeInstance (prefab) as GameObject;
//		go.SetActive(false);
//		go.Transform.parent = GameObject.Transform;
//		deactiveObjs.Add(go);
//
//	}
//
//
//}
