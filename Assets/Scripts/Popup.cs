using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour {
    public GameObject text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other){
        text.GetComponent<UnityEngine.UI.Text>().enabled = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        text.GetComponent<UnityEngine.UI.Text>().enabled = false;
    }
}
