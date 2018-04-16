using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptSpawn : MonoBehaviour {

    public GameObject enemy;
    public int seconds;


	// Use this for initialization
	void Start () {
        InvokeRepeating("spawnEnemy", 0, this.seconds);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void spawnEnemy(){
        Instantiate(enemy).transform.position = transform.position;
    }
}
