using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptLance : MonoBehaviour {

	public float speed;
	private GameObject player;
	private float tempoDeVida = 4;

	void Start () {
		this.player = GameObject.FindWithTag("Player");
		Destroy(gameObject, tempoDeVida); 
	}

	// Update is called once per frame
	void Update () {
		transform.position =
			Vector2.MoveTowards(
				gameObject.transform.position,
				player.transform.position,
				this.speed * Time.deltaTime
			);	
	}
}
