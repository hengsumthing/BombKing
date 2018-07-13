using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrot : MonoBehaviour {
    public static float slowTimeScale = 1.2f;
    public static float normalTimeScale = 10f;
    public static float timeOut = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "kim")
        {
            other.GetComponent<bluemonster>();
            bluemonster.movespeed -= 1.8f;
            other.GetComponent<timer>();
            timer.maxtime += 10;
            timer.timeleft += 10;
            Destroy(gameObject);
            //bluemonster.movespeed += 1.2f;
        }
       
    }
    public static IEnumerator CountDown()
    {
        move.speed = slowTimeScale;
        yield return new WaitForSeconds(timeOut);
        move.speed = normalTimeScale;
    }
}
