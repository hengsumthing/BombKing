using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDrop2 : MonoBehaviour
{
    public GameObject bombPrefab;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (bbombcontroller.bbomb >= 0)
            {
                Vector2 pos = transform.position;
                pos.x = Mathf.Round(pos.x);
                pos.y = Mathf.Round(pos.y);
                Instantiate(bombPrefab, pos, Quaternion.identity);
            }
        }

    }
}
