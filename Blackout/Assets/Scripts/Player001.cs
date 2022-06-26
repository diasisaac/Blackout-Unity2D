using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player001 : MonoBehaviour {
	//PoolManeger enemiesPool;
	// Floats
	public MorcegoIA morcego;
	public float maxSpeed = 3;		
	public float speed = 50f;
	public float JumPower = 150f;
	//References
	private Rigidbody2D rb2d;

	private Animator animi;

	//Booleas
	public bool candDoubleJump;
	public bool grounded;
	public bool slide;
	public bool isHiding;
	private bool isDead;
	//Estadps 
	public int maxHealt = 100;
	public int curHealt;
	public SpriteRenderer rend;
	BoxCollider2D boxcol;
	//Trasforms
	public Transform esconderijo;
	public Transform player;
	// Use this for initialization

	void Start () {
		isHiding = false;
		morcego = (MorcegoIA)GetComponentInParent (typeof(MorcegoIA));
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		animi = gameObject.GetComponent<Animator> ();
		boxcol = this.gameObject.GetComponent<BoxCollider2D> ();
		curHealt = maxHealt;
		rend = this.gameObject.GetComponent<SpriteRenderer> (); 
		
//		enemiesPool = Singleton.GetIntance ().poolManeger;
	}

	// Update is called once per frame
	void Update () {
		animi.SetBool ("Grounded", grounded);
		animi.SetFloat ("Speed", Mathf.Abs(rb2d.velocity.x));

		//esconder();

		//gameObject.SetActive(false);
//
		if (Input.GetAxis("Horizontal") < -0.1f) {

			transform.localScale = new Vector3 (-1, 1, 1);		
			print("Clicked");
			Sending.sendRed();
		}
		if (Input.GetAxis ("Horizontal") > 0.1f) {

			transform.localScale = new Vector3 (1, 1, 1);
			print("Clicked");
			Sending.sendGreen();
		}
		if (Input.GetButtonUp ("Jump")) { // PULO
			if (grounded)
			{
				rb2d.velocity = new Vector2(rb2d.velocity.x, JumPower);
				candDoubleJump = true;
				Debug.Log ("primeiro");
				//"Primiero pulo"
				Sending.sendYellow();
			} 
			else {
				if (candDoubleJump) {
				
					candDoubleJump = false;
					rb2d.velocity = new Vector2 (rb2d.velocity.x, 0);
					rb2d.AddForce (Vector2.up * JumPower / 1.75f);
					Debug.Log ("segundo pulo");
					//"Segundo Pulo"

				}
			}
		}
//		if (Input.GetKeyDown (KeyCode.RightControl)) { // slide
//			
//			slide = true;
//			rb2d.AddForce (Vector2.down * speed);
//			animi.SetBool ("Slide", true);
//		
//		}
//
//		if(Input.GetKeyDown(KeyCode.C)){ // aparecer e desaparecer...

//			rend.enabled = !rend.enabled;
//			boxcol.enabled = !boxcol.enabled;

			//gameObject.activeSelf = !gameObject.activeSelf;
			//this.GetComponent<Collider2D>().enabled = false;
			//GetComponent<Collider2D>().enabled = !GetComponent<Collider2D>().enabled ;
//		}

	
		if (curHealt > maxHealt) { // esboço da vida
			curHealt = maxHealt;
		
		}
	
//		if (Input.GetMouseButtonDown(1)) {
//			enemiesPool.Spawn ();
//		}

	}
	void FixedUpdate(){ //Movimentação restinho
			
		Vector3 easevelocity = rb2d.velocity;
		easevelocity.y = rb2d.velocity.y;
		easevelocity.z = 0.0f;
		easevelocity.x *= 0.75f;

		//Falsa friccao

		if (grounded) 
		{
			rb2d.velocity = easevelocity;
		}
		float h = Input.GetAxisRaw ("Horizontal");
		//Movendo o player
		rb2d.AddForce ((Vector2.right * speed) * h);
	
		//rb2d.velocity = new Vector2 ((rb2d.velocity.x * speed) * h, rb2d.velocity.y);
		//Limitnado a velocidade do player
		if (rb2d.velocity.x > maxSpeed) {
		
			rb2d.velocity = new Vector2 (maxSpeed, rb2d.velocity.y);		
		}
		if (rb2d.velocity.x < -maxSpeed) {
			
			rb2d.velocity = new Vector2 (-maxSpeed, rb2d.velocity.y);
		
		}
//		if(slide && !this.animi.GetCurrentAnimatorStateInfo(0).IsName("Slide")){
//			
//			animi.SetBool ("Slide", true);
//		}
//		else if(this.animi.GetCurrentAnimatorStateInfo(0).IsName("Slide")){
//
//			animi.SetBool ("Slide", false);
//		}

	}
	void PDead()
	{	//Restart
		
	}

	public IEnumerator KnockBack(float KnockDur, float KnockbackPwd, 	Vector3 knockbackDir){ //ESPINHOS

		float timer = 0; 
			while(KnockDur > timer){
			timer += Time.deltaTime;
			rb2d.AddForce (new Vector3 (knockbackDir.x - 100, knockbackDir.y * KnockbackPwd, transform.position.z));
			}
		yield return 0;
	}
	void OnTriggerEnter2D( Collider2D coll){

		if (coll.tag == ("door")) {
			
			SceneManager.LoadScene ("QuedaBarril");
		}

	}//fecha o trigger enter

	void OnTriggerStay2D(Collider2D coll) {
		
		bool boolean = Input.GetKey (KeyCode.C) && coll.tag == ("esconderijo");

		if (boolean && rend.sortingOrder != -1) {
			transform.position = esconderijo.position;
			rend.sortingOrder = -2;
			rend.color = Color.black;
			isHiding = true;
			Debug.Log ("escondeu");
		} 
		else if (boolean) {
			rend.sortingOrder = 5	;
			rend.color = Color.white;

		}

	}// encerra o triggerstay

	void OnTriggerExit2D(Collider2D coll){
		if (coll.tag == ("esconderijo") && rend.sortingOrder != -1) {
			rend.sortingOrder = 5;
			rend.color = Color.white;
			isHiding = false;

		}

	}// fim triggerexit

//	public void jumpp(){
//
//
//		if (grounded && Input.GetKey(KeyCode.Space))
//			{
//				rb2d.velocity = new Vector2(rb2d.velocity.x, JumPower);
//				candDoubleJump = true;
//				//"Primiero pulo"
//			} 
//			else if (candDoubleJump) 
//		        {
//
//					candDoubleJump = false;
//					rb2d.velocity = new Vector2 (rb2d.velocity.x, 0);
//					rb2d.AddForce (Vector2.up * JumPower / 1.75f);
//					//"Segundo Pulo"
//				}
//			}
		
}
