using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontTriggerTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.eulerAngles = new Vector3(0, 0, 90);
        //transform.Translate(Vector3.up * Time.deltaTime, Space.World);

    }
	
	// Update is called once per frame
	void Update () {
        transform.eulerAngles = new Vector3(0, 0, 90);
    }
}
