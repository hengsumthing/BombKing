using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour {
    public GameObject live, live1, live2, gameover, restart;
    public static int health;
    
    

	// Use this for initialization
	void Start () {
        health = 3;
        live.gameObject.SetActive(true);
        live1.gameObject.SetActive(true);
        live2.gameObject.SetActive(true);
        gameover.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (health > 3)
            health = 3;

        switch (health)
        {
           

            case 3:
                live.gameObject.SetActive(true);
                live1.gameObject.SetActive(true);
                live2.gameObject.SetActive(true);
                break;

                case 2:
                live.gameObject.SetActive(true);
                live1.gameObject.SetActive(true);
                live2.gameObject.SetActive(false);
                break;

            case 1:
                live.gameObject.SetActive(true);
                live1.gameObject.SetActive(false);
                live2.gameObject.SetActive(false);
                break;

            case 0:
                live.gameObject.SetActive(false);
                live1.gameObject.SetActive(false);
                live2.gameObject.SetActive(false);
                gameover.gameObject.SetActive(true);
                restart.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;

        }
		
	}
}
