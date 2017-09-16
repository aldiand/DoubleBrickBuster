using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Bricks.BrickCount = 0;
		Debug.Log ("Requesting level : " + name);
		SceneManager.LoadScene (name);
	}

	public void LoadNextLevel(){
		Bricks.BrickCount = 0;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void BrickDestroyed(){
		if (Bricks.BrickCount <= 0) {
			LoadNextLevel ();
		}
	}

	public void QuitGame(){
		Debug.Log ("QUIT!");
		Application.Quit ();
	}
}
