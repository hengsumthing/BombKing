using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disablecollider : MonoBehaviour {
   
   
    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.gameObject.tag == "enemy")
        {
            Debug.Log("hit");
            co.gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }
}
