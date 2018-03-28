using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartScrypt : MonoBehaviour {
    public Sprite[] heartSprites;
    public Image HeartUI;
    private PlayerController player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    
    void Update()
    {
        HeartUI.sprite = heartSprites[player.CurrentHealth];
    }
}
