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

}
