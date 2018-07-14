using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour {
    public static int enemyKilled = 0;
    public static int totalEnemies;
    public static bool win = false;


   

    public Text winn;
    public Text nextt;
	// Use this for initialization
	void Start () {
     
        winn.enabled = false;
        nextt.enabled = false;
        totalEnemies= GameObject.FindGameObjectsWithTag("enemy").Length;
        //had to multiply by 3 to make up for enemyKilled counting the # of objects destroyed not just the enemy sprite
        totalEnemies = totalEnemies * 3;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
       
        

        if (enemyKilled >= totalEnemies)
        {
            
            winn.enabled = true;
            nextt.enabled = true;
            win = true;
        }
   
       
	}
 
}
