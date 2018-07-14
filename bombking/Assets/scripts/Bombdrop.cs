using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombdrop : move {
    public GameObject bombPrefab;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (sbombcontroller.smbomb >= 0 )
            {
                Vector2 pos = transform.position;
                
                if (directionL == true){

                    pos.x = pos.x - 1;
                }
                else if (directionR == true)
                {

                    pos.x = pos.x + 1;
                }
                else if (directionU == true)
                {

                    pos.y = pos.y + 1;
                }
                else if (directionD == true)
                {
                    
                    pos.y = pos.y - 1;
                }

                //pos.x = Mathf.Round(pos.x)+0.5f;
                //pos.y = Mathf.Round(pos.y)+0.5f;
                Instantiate(bombPrefab, pos, Quaternion.identity);
            }
        }

    }
}
