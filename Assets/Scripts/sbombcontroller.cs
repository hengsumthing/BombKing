using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sbombcontroller : MonoBehaviour
{
    public GameObject bomb1, bomb2, bomb3;
    public static int smbomb;
    public static float reload = 7;


    // Use this for initialization
    void Start()
    {
        smbomb = 10;
        bomb1.gameObject.SetActive(true);
        bomb2.gameObject.SetActive(true);
        bomb3.gameObject.SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {
        if (smbomb > 3)
            smbomb = 3;

        switch (smbomb)
        {


            case 3:
                bomb1.gameObject.SetActive(true);
                bomb2.gameObject.SetActive(true);
                bomb3.gameObject.SetActive(true);
                break;

            case 2:
                bomb1.gameObject.SetActive(true);
                bomb2.gameObject.SetActive(true);
                bomb3.gameObject.SetActive(false);
                break;

            case 1:
                bomb1.gameObject.SetActive(true);
                bomb2.gameObject.SetActive(false);
                bomb3.gameObject.SetActive(false);
                break;

            case 0:
                bomb1.gameObject.SetActive(false);
                bomb2.gameObject.SetActive(false);
                bomb3.gameObject.SetActive(false);
                
                break;


        }

        // reload use coroutine
        

        if (sbombcontroller.smbomb < 3) 
        {
            
            reload -= Time.deltaTime;
            Debug.Log("reload" + reload);
            if (reload <= 0)
            {

                sbombcontroller.smbomb += 1;
                reload = 7;
                
            }
        }
    }
}

