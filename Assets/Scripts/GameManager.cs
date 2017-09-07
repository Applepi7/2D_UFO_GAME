using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Text scoreText;
    public Text winText;

    private int maxPickup = 12;
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "SCORE : " + PlayerController.instance.score;
        if (PlayerController.instance.score == maxPickup)
        {
            winText.text = "YOU WIN!!!!";
        }
	}
}
