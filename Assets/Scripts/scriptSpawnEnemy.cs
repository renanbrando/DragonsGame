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
	float timecount = 1.0f ;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < spawn.Length; i++) {
			warior[i] = Instantiate (WariorPrefab, spawn[i].position, spawn[i].rotation) as GameObject;
			index = i;

		}
	}
	
	// Update is called once per frame
	void Update () {
		wariorDeath ();

		
		}
	void wariorDeath(){
		if (warior [1].activeInHierarchy == false && warior[0].activeInHierarchy == false) {
			warior [1].SetActive(true);
			warior [0].SetActive(true);
		}

		}
	void varrer (){
	}


		}
		//}

