using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptSpawnEnemy : MonoBehaviour {
	//public Transform[] pointsSpawn;
	public GameObject WariorPrefab;
	public Transform[] spawn;
	public bool death;
	public GameObject[] warior;
	int count = 0;
	int index;
	int a = 1;
	float timecount = 1.0f;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < spawn.Length; i++) {
			warior[i] = Instantiate (WariorPrefab, spawn[i].position, spawn[i].rotation) as GameObject;

		}

	}
	
	// Update is called once per frame
	void Update () {
		wariorDeath ();

		
		}
	void wariorDeath(){
		if (warior[0].activeInHierarchy == false) {
			for (int i = 0; i < warior.Length; i++) {
					warior[i].SetActive(true); 
			}
		}
		
		}

}
	
