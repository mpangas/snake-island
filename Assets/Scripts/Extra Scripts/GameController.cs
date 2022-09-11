using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public PlayerMovement PlayerMovement;

	public GameOverScreen GameOverScreen;
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape"))
            Application.Quit();
	}

	public void GameOver() {
		PlayerMovement.disabled = true;
		GameOverScreen.Setup();
	}
}
