using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour {
    public GameObject explosionPrefab;
  
    

    void OnDestroy()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);


    }
    void OnStart()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<Collider2D>().enabled = false;
        Debug.Log("enter");

    }

    void OnTriggerExit2D(Collider2D other)
    {
        GetComponent<Collider2D>().enabled = true;
       
        Debug.Log("exit");
    }
}
