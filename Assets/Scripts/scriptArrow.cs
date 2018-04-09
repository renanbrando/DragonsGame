using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptArrow : MonoBehaviour {
    
    public float speed;
    private GameObject player;

	// Use this for initialization
	void Start () {
        this.player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position =
            Vector2.MoveTowards(
                gameObject.transform.position,
                player.transform.position,
                this.speed * Time.deltaTime
            );	
        //transform.Rotate();
	}
}
