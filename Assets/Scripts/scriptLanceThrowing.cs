using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptLanceThrowing : MonoBehaviour {

	public GameObject lanceThrowing;
	bool canThrown = true;
 
	// Update is called once per frame
	void Update () {
		if (canThrown == true)  {
			StartCoroutine(Thrown());
		}
	}

	IEnumerator Thrown(){
		canThrown = false;
		Instantiate (lanceThrowing, transform.position, transform.rotation);
		yield return new WaitForSeconds (3.6f);
		canThrown = true;
	}
}
