using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("n")) 
        {
            SceneManager.LoadScene("bkscene2");
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown("n") && EnemyCount.enemy < 3)
        {
            SceneManager.LoadScene("bkscene1");
            Time.timeScale = 1;
        }
    }
}