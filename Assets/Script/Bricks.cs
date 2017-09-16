using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {
	public AudioClip crack;

	public static int BrickCount = 0;
	public Sprite[] hitSprites;

	public int maxHits;
	private int hitCounts;
	private LevelManager levelMan;

	private bool isBreakable;

	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");

		if (isBreakable) {
			BrickCount++;
		}

		print (BrickCount);
		levelMan = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (isBreakable) {
			AudioSource.PlayClipAtPoint (crack, this.transform.position);


			hitCounts++;
			int spriteIndex = hitCounts - 1;

			if (hitCounts >= maxHits) {
				BrickCount--;
				levelMan.BrickDestroyed ();
				Destroy (gameObject);
			} else {
				this.GetComponent<SpriteRenderer>().sprite=hitSprites[spriteIndex]; 
			}
		}
	}
}
