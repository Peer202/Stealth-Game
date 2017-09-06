using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {
	public Rigidbody2D rb;
	public  Vector2 vorwärts;
	public Vector2 seitwärts;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Horizontal") > 0) { //d
			rb.MovePosition (rb.position + seitwärts * Time.deltaTime);
			rb.MoveRotation (0);
		
		}//d	
		if (Input.GetAxis ("Horizontal") < 0) { //a
			rb.MovePosition (rb.position + (-1*seitwärts) * Time.deltaTime);
			rb.MoveRotation (180);
		}//d
		if (Input.GetAxis ("Vertical") > 0) { //w
			rb.MovePosition (rb.position + vorwärts * Time.deltaTime);
			rb.MoveRotation (90);

		}//d
		if (Input.GetAxis ("Vertical") < 0) {//s
			rb.MovePosition (rb.position + (-1*vorwärts) * Time.deltaTime);
			rb.MoveRotation (270);

		}
	}
}
