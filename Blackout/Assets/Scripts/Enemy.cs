using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private Rigidbody2D rb;
	private Transform tr;
	private Animator animi;
	public Transform verificaParede;
	public Transform verifficaChao;

	public bool estanaParede;
	public bool estanoChao;
	public bool viradoDireita;

	public float velocidade;
	public float raioValidaChao;
	public float raioValidaParede;

	public LayerMask solido;

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody2D> ();
		tr = GetComponent<Transform> ();
		animi = GetComponent<Animator> ();


		viradoDireita = true;

	}

	// Update is called once per frame
	void FixedUpdate(){

		EnemyMoviments ();
	}
	void Update () {

	}
	void EnemyMoviments(){
	
	
		estanaParede = Physics2D.OverlapCircle (verificaParede.position, raioValidaParede, solido);
		estanoChao = Physics2D.OverlapCircle (verifficaChao.position, raioValidaChao, solido);
	
	
		if ((!estanoChao || estanaParede) && viradoDireita) 
		
			Flip ();
		else if ((!estanoChao || estanaParede) && !viradoDireita)
			Flip();

		if (estanoChao) {
		
		
			rb.velocity = new Vector2 (velocidade, rb.velocity.y);
		
		}
	}


	void Flip(){


		viradoDireita = !viradoDireita;
		tr.localScale = new Vector2(-tr.localScale.x,tr.localScale.y);

		velocidade *= -1;

	}
	void OnDrawGizmosSelected(){
	
		Gizmos.color = Color.red;

		Gizmos.DrawWireSphere (verifficaChao.position, raioValidaChao);
		Gizmos.DrawWireSphere (verificaParede.position, raioValidaParede);

	}


}
