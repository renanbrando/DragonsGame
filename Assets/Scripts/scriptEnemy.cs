using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEnemy : MonoBehaviour {

	public float life;
	public float interval;
	public GameObject enemyPrefab;
	public GameObject explotionGo;

	// Use this for initialization
	IEnumerator Start () {
		Instantiate (enemyPrefab);
		yield return new WaitForSeconds (interval);
		StartCoroutine (Start ());
	}
	// Update is called once per frame
	void Update () {

	} 

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag.ToLower() == "fire") {
			life--;
			if (life < 1) {
				PlayExplotion (); 
				Destroy (col.gameObject);
				Destroy (gameObject);
			} else {
				Destroy(col.gameObject);
			}
		}
	}


	//function to instantiate the explotion
	void PlayExplotion(){
		GameObject explotion = (GameObject)Instantiate (explotionGo);

		//set the position of the explotion
		explotion.transform.position = transform.position;
	}
}
