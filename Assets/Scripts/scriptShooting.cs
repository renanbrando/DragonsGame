using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptShooting : MonoBehaviour {

	public GameObject fireShoot;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Fire1")) {
			Instantiate (fireShoot, transform.position, transform.rotation);
		}
	}

	IEnumerator fire(){
		if (Input.GetButtonUp("Fire1")) {
			Instantiate (fireShoot, transform.position, transform.rotation);
		}
		yield return new WaitForSeconds (0.1f);
		StartCoroutine (fire ());
	}
}
