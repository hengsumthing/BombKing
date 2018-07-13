using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour {
    public static int enemy = 0;
    public Text winn;
    public Text nextt;
	// Use this for initialization
	void Start () {
      //  enemy = 0;
        winn.enabled = false;
        nextt.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
       
        if (enemy > 11)
        {
            winn.enabled = true;
            nextt.enabled = true;
        }
     //  else if 
     //   {
       //     winn.enabled = false;
      //  }
       
	}
    void track()
    {
       
    }
}
