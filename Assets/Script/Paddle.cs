using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 PaddlePos = new Vector2 (this.transform.position.x, this.transform.position.y);

		float MousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		PaddlePos.x = Mathf.Clamp(MousePosInBlocks, 1f, 15f);

		this.transform.position = PaddlePos;
	}
}
