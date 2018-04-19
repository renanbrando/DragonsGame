using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptInvoke : MonoBehaviour {
	
	public GameObject enemy;

	void Start()
	{
		float sec = Random.Range (2.5f, 5.5f);
		InvokeRepeating("SpawnEnemy", 1, sec);
	}

	void SpawnEnemy()
	{
		float y = Random.Range (-2.9f, -4.3f);
		Instantiate(enemy, new Vector3(6.76f, y, 0), Quaternion.identity); 
	}
}
