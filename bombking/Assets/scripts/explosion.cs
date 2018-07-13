using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
                 
public class explosion : MonoBehaviour {
    public GameObject dead;
    public Tile testTile;
	// Use this for initialization
	void Start () {
		//
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D co)
    {
        //Debug.Log("trigger enter test");
        if (co.gameObject.gameObject.tag != "Indes")
        {
            if (co.gameObject.gameObject.tag == "enemy" || co.gameObject.gameObject.tag == "monster" )
            {
                Destroy(co.gameObject);
            }
            else
            {
                //Debug.Log("test gameobject tag");
                int x = Mathf.RoundToInt(transform.position.x);
                int y = Mathf.RoundToInt(transform.position.y);

                Tilemap innertm = co.transform.gameObject.GetComponent<Tilemap>();
                Vector3Int bombPos = innertm.WorldToCell(transform.position);
                innertm.SetTile(bombPos + new Vector3Int(0, 1, 0), testTile);
                innertm.SetTile(bombPos + new Vector3Int(1, 1, 0), testTile);
                innertm.SetTile(bombPos + new Vector3Int(1, 0, 0), testTile);
                innertm.SetTile(bombPos + new Vector3Int(0, 0, 0), testTile);
                innertm.SetTile(bombPos + new Vector3Int(1, -1, 0), testTile);
                innertm.SetTile(bombPos + new Vector3Int(0, -1, 0), testTile);
                innertm.SetTile(bombPos + new Vector3Int(-1, -1, 0), testTile);
                innertm.SetTile(bombPos + new Vector3Int(-1, 0, 0), testTile);
                innertm.SetTile(bombPos + new Vector3Int(-1, 1, 0), testTile);
            }

           
        }
                                

       
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "kim")
        {
            GameControlScript.health = 0;
        }
        if(other.tag== "enemy")
        {
            Destroy(other.gameObject);
            GameObject fire = (GameObject)Instantiate(dead, other.gameObject.transform.position, Quaternion.identity);
            Destroy(fire, 0.5f);
            EnemyCount.enemy += 1; 
            Score.score +=1 ;
            Destroy(gameObject);
        }
    }
    void OnTriggerStay2D(Collider2D co)
    {
        
        {
            
        }
    }


}
 


