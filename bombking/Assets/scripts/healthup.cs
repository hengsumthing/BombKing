using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthup : MonoBehaviour {
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void Awake()
    {
        

    }
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.isStatic)
            Destroy(co.gameObject);

        if (co.tag == "kim")
        {
            if (GameControlScript.health < 3)
            {
                GameControlScript.health += 1;
                Destroy(gameObject);
            }

        }
    }
}
