using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEnemyMovement : MonoBehaviour {

	Animator animator;
	private int currentlife;
	public GameObject explotionGo;
	public GameObject lanceThrowing; 
	private float timeLimitLance = 0; 
	private float varLimitLance = 0.5f; 
	private float timeLimitEnemy = 0;
	private float varLimitEnemy = 2f; 
	private int life;

	// Use this for initialization
	void Start () { 
		animator = GetComponent<Animator>();
		//Range with integer is not maximally inclusive.
		life = Random.Range (1, 3);
		currentlife = life;

		timeLimitEnemy += varLimitEnemy;
		timeLimitLance = varLimitLance + varLimitEnemy;
	} 

	// Update is called once per frame
	void Update () {
		Move();
		Attack();
	}

	private void Attack()
	{
		animator.SetBool ("isThrowing", false);
		if (Time.time >= timeLimitEnemy) {
			animator.SetBool ("isThrowing", true);
			timeLimitEnemy = varLimitEnemy + Time.time ;
			timeLimitLance = varLimitLance + Time.time ;  
		}
		if (Time.time >= timeLimitLance) { 
			Instantiate (lanceThrowing, transform.position, transform.rotation);
			timeLimitLance += varLimitEnemy;
		}
	}
	 
 
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag.ToLower() == "fire")
		{
			life--;
			if (life < 1)
			{
				PlayExplotion();
				Destroy(this.gameObject);
				Destroy(col.gameObject);
				gameObject.SetActive(false);
				life = currentlife; 
			}
			else
			{ 
				Destroy(col.gameObject);
			}
		}
		else if (col.gameObject.CompareTag("DeathZone"))
		{
			Destroy(this.gameObject);
		}
	}
 
	// function that moves the enemy
	void Move(){
		transform.Translate(Vector2.left * 1f * Time.deltaTime);
	}
	 
	// function to instantiate the explotion
	void PlayExplotion(){
		GameObject explotion = (GameObject)Instantiate (explotionGo);
		//set the position of the explotion
		explotion.transform.position = transform.position;
	} 
}
