using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEnemy : MonoBehaviour {

	public int life;
	public float interval;
	public GameObject explotionGo;
    public GameObject arrow;
    public Animator anim;
	public bool death;
	public int currentlife;
    private bool canShoot = false;
    private float lastShoot = 0;

	// Use this for initialization
    void Start () {
		currentlife = life;
    }

	// Update is called once per frame
	void Update () {
        move();
        shoot();
	}

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag.ToLower() == "fire")
        {
            life--;
            if (life < 1)
            {
                PlayExplotion();
                Destroy(col.gameObject);
                gameObject.SetActive(false);
                life = currentlife;

                //Destroy (gameObject);
            }
            else
            {
                Destroy(col.gameObject);
            }
        }
        else if (col.gameObject.CompareTag("BornZone"))
        {
            this.canShoot = true;
        }
        else if (col.gameObject.CompareTag("DeathZone"))
        {
            Destroy(this.gameObject);
        }
            
	}

    // function that moves the warrior
    void move(){
        transform.Translate(Vector2.left * 1 * Time.deltaTime);
    }

    // function that shoots an arrow
    void shoot(){
        if (Time.time > lastShoot + 3){
            Instantiate(arrow);
            //anim.SetTrigger("shooting");
            arrow.transform.position = transform.position + new Vector3(-1, 0);

            this.lastShoot = Time.time;
        }
    }

	// function to instantiate the explotion
	void PlayExplotion(){
		GameObject explotion = (GameObject)Instantiate (explotionGo);

		//set the position of the explotion
		explotion.transform.position = transform.position;
	}
}
