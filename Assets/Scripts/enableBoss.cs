using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableBoss : MonoBehaviour {
    public GameObject boss;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        boss.GetComponent<BossController>().enabled = true;
        boss.GetComponent<Collider2D>().enabled = true;
        GameObject.Find("bosstrigger").GetComponent<SpriteRenderer>().enabled = false;
    }
}
