using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameUIScript : MonoBehaviour {
    public float second,minutes;
    public Text counterText;

	// Use this for initialization
	void Start () {
        counterText = GetComponent<Text>() as Text;
	}
	
	// Update is called once per frame
	void Update () {
        minutes = (int)(Time.time / 60f);
        second = (int)(Time.time % 60f);
        counterText.text = minutes.ToString("00") + ":" + second.ToString("00");
	}
}
