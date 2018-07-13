using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombpickup : MonoBehaviour {

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
            if (sbombcontroller.smbomb < 3)
            {
                sbombcontroller.smbomb += 1;
                Destroy(gameObject);
            }

        }
    }
}
