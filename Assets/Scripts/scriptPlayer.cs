using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlayer : MonoBehaviour {

	//Animator animator;

	public float speed;
	float move_x;
	public int vidas;
	float move_y; 
	//SpriteRenderer spriteRenderer;
	//Transform spawm_Fire;

	// Use this for initialization
	void Start () {
		//spriteRenderer = GetComponent<SpriteRenderer>();
		//spawm_Fire = GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update () {

		//Move o Dragao
		move_y = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
		move_x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
		transform.Translate (move_x, move_y, 0.0f);
	 

		//fire ();
	}

	//????? 
	//void fire(){		
	//	if (Input.GetButton("Fire1")) {
	//		animator.SetBool ("isFire", true);
	//	} else {
	//		animator.SetBool ("isFire", false);
	//	}
	//}

	/*
	void OnTriggerEnter2D(Collider2D c){
		if (c.gameObject.tag == "arrow") {
			vidas--;
			Debug.Log (vidas);
		}
		if (vidas <= 0) {
			Destroy (gameObject);
		}
	}
*/
	void OnCollisionEnter2D(Collision2D coll){
		//Debug.Log ("bateu");
	}

}
