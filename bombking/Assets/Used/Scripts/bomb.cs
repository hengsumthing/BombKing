using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour {
    public GameObject explosionPrefab;

    void OnDestroy()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);


    }
}
