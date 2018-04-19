using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptShooting : MonoBehaviour {

	public GameObject fireShoot;
	bool canFire = true;
	public float waitFire;
 
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1") && (canFire == true) || (Input.GetButtonDown("Jump") && (canFire == true)))  {
			StartCoroutine(fire());
		}
	}

	IEnumerator fire(){
		canFire = false;
		Instantiate (fireShoot, transform.position, transform.rotation);
		yield return new WaitForSeconds (waitFire);
		canFire = true;

	}
}
