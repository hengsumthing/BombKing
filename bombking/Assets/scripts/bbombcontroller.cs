using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bbombcontroller : MonoBehaviour
{
    public GameObject bomb, bomb1, bomb2;
    public static int bbomb;
    


    // Use this for initialization
    void Start()
    {
        bbomb = 3;
        bomb.gameObject.SetActive(true);
        bomb1.gameObject.SetActive(true);
        bomb2.gameObject.SetActive(true);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bbomb > 3)
           bbomb = 3;

        switch (bbomb)
        {


            case 3:
                bomb.gameObject.SetActive(true);
                bomb1.gameObject.SetActive(true);
                bomb2.gameObject.SetActive(true);
                break;

            case 2:
                bomb.gameObject.SetActive(true);
                bomb1.gameObject.SetActive(true);
                bomb2.gameObject.SetActive(false);
                break;

            case 1:
                bomb.gameObject.SetActive(true);
                bomb1.gameObject.SetActive(false);
                bomb2.gameObject.SetActive(false);
                break;

            case 0:
                bomb.gameObject.SetActive(false);
                bomb1.gameObject.SetActive(false);
                bomb2.gameObject.SetActive(false);
                break;


        }

    }
}

