using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : EnemyCount
{
    public GameObject finishLine;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnTriggerEnter2D(Collider2D co)
    {
          if (co.gameObject.tag == "kim")
        {
            Debug.Log("hi winner");
            winn.enabled = true;
            nextt.enabled = true;
            win = true;
        }
    }
}
