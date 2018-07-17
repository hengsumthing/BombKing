using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bbomb : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag == "kim")
        {
            if (bbombcontroller.bbomb < 3)
        {
            bbombcontroller.bbomb += 1;
            Destroy(gameObject);
        }
        }

        
    }
}
