using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptPlayer : MonoBehaviour {

	Animator animator;
	public float speed;
    public int life;
	private float move_x;
	private float move_y;
	private float timeToLoadScene = 3;
   
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		//Move o Dragao
		move_y = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
		move_x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
		transform.Translate (move_x, move_y, 0.0f);	 
	}

	void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.CompareTag("Enemy")){
            life--;
            if (life < 1){
				animator.SetBool ("isDeath", true);
				Invoke("GoToGameOver", timeToLoadScene); 
            }
            Destroy(col.gameObject);
        }
	}
 
    // function that ends the game and goes to menu
    void GoToGameOver(){ 
        SceneManager.LoadScene("menu-scene");
    }

}
