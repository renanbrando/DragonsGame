using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEnemy : MonoBehaviour {

	public float life;
	public float interval;
	public GameObject explotionGo;
    public GameObject arrow;
    public Animator anim;
    private float lastShoot = 0;

	// Use this for initialization
    void Start () {
        
    }

	// Update is called once per frame
	void Update () {
        if (Time.time > lastShoot + 3){
            shoot();
        }
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

    //function that shoots an arrow
    void shoot(){
        Instantiate(arrow);
        anim.SetTrigger("shooting");
        arrow.transform.position = transform.position + new Vector3(-1,0);

        this.lastShoot = Time.time;
    }

	//function to instantiate the explotion
	void PlayExplotion(){
		GameObject explotion = (GameObject)Instantiate (explotionGo);

		//set the position of the explotion
		explotion.transform.position = transform.position;
	}
}
