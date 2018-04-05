using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptFire : MonoBehaviour {
	
	public float velocidade;
	public float tempoDeVida;

	SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, tempoDeVida); 
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.right * velocidade * Time.deltaTime);
	}

	//void OnCollisionEnter2D(Collision2D col){
	//	if (col.gameObject.tag.ToLower() == "enemy") {
	//		Destroy(col.gameObject);
	//		Destroy(gameObject);
	//	}
	//}

	void OnTriggerEnter2D(Collider2D c) {		
		//Debug.Log ("test enemy");
		//if (c.gameObject.tag == "enemy") {			
		//	Debug.Log ("enemy");
		//	Destroy(c.gameObject);
		//	Destroy(gameObject);
		//}
	} 
}
