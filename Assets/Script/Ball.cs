using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Paddle paddle;

	private Vector3 PaddletoBallPos;

	private Rigidbody2D rb;

	private bool GameStarted = false;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();

		PaddletoBallPos = this.transform.position - paddle.transform.position;
		rb = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameStarted) {
			this.transform.position = paddle.transform.position + PaddletoBallPos;

			if (Input.GetMouseButtonDown (0)) {
				rb.velocity = new Vector2 (3f, 10f);
				GameStarted = true;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (GameStarted) {
			this.GetComponent<AudioSource> ().Play ();
		}
	}
}
