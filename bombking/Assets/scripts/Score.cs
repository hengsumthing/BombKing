using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public static int score = 0 ;
    public Text scoreTxt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void updatescore()
    {
        score++;
    }
    private void LateUpdate()
    {
        scoreTxt.text = "Score:  " + score;
    }
}
