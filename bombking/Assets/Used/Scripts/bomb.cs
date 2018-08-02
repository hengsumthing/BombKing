using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour {
    public GameObject explosionPrefab;
    //public CircleCollider2D circol;

    // private Collider2D col;
    

    void OnDestroy()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<Collider2D>().enabled = false;
        //circol.enabled = false;
    }
}
