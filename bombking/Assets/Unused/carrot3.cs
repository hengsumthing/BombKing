﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carrot3 : MonoBehaviour
{
    public static float speedup = 60;
    public static float normalspeed = 10;
    public static float timeOut = 10;
    public GameObject bombPrefab;
    public Text ttimesuptext;
    //   public timer t;

    //  private timer temp;

    // Use this for initialization
    void Start()
    {
        ttimesuptext.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "kim")
        {
            other.GetComponent<move>().StartCoroutine(CountDown());
            other.GetComponent<BombDrop2>();
            other.GetComponent<timer>();
            timer.maxtime += 10;
            timer.timeleft += 10;
            //  t.enabled = true;


            Destroy(gameObject);
        }
      //  if (timer.timeleft ==0)
    //    {
    //        other.GetComponent<Bombdrop>();
    //    }

    }
    public static IEnumerator CountDown()
    {
       // move.speed = speedup;
        yield return new WaitForSeconds(timeOut);
       
      //  move.speed = normalspeed;
      
    }
}