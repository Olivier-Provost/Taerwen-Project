using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGraber: MonoBehaviour {

   private int point =0;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            GameObject.Destroy(collision.gameObject);
            point++;

        }
    }

   
}
