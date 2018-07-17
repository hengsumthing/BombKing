using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    Image timerbar;
    public static float maxtime=0 ;
    public static float timeleft=0;
    public GameObject ttimesuptext;

    // Use this for initialization
    void Start()
    {
        ttimesuptext.SetActive(false);
        timerbar = GetComponent<Image>();
        timeleft = maxtime;

    }

    // Update is called once per frame
    void Update()
    {
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            timerbar.fillAmount = timeleft / maxtime;
        }
        else
        {
            ttimesuptext.SetActive(true);
            //Time.timeScale = 0;
        }

    }
}
