using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinGraber: MonoBehaviour {

    public Text scoreText;

    private int points = 0;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Coin") {
            GameObject.Destroy(collision.gameObject);
            points++;
            scoreText.text = "Score : " + points;
        }
    }

   
}
