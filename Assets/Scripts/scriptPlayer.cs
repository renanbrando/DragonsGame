using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scriptPlayer : MonoBehaviour {
	public Rigidbody2D rb;
	Animator animator;
	public float speed;
    public Text lifeText;
    public int life;
	private float move_x;
	private float move_y;
	private float timeToLoadScene = 2;
	public float waitFire;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
        UpdateLife();
		Movement ();
	}

	void Movement()
	{
		move_y = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
		move_x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);	
			transform.eulerAngles = new Vector2(0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);	
			transform.eulerAngles = new Vector2(0, 180);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (move_x, move_y, 0.0f);	
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (move_x, move_y, 0.0f);
		}
	}

    void UpdateLife(){
        if (this.life >= 0){
            this.lifeText.text = this.life.ToString();  
        }
    }
  
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.CompareTag("Lance") || col.gameObject.CompareTag("Enemy")){
            life--;
            if (life < 1){				
				animator.SetBool ("isDeath", true);
				rb.gravityScale = 1;
				Invoke("GoToGameOver", timeToLoadScene); 
            }
			if (col.gameObject.CompareTag("Lance"))
            	Destroy(col.gameObject);
		} 
 
	}
 
    // function that ends the game and goes to menu
    void GoToGameOver(){ 
        SceneManager.LoadScene("menu-scene");
    }

}
