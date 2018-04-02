using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlayer : MonoBehaviour {
	Rigidbody2D rb;
	public float impulso;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			rb.velocity = new Vector2 (0.0f, impulso);
		}
	}
}
