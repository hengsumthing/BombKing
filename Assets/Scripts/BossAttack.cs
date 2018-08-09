using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag == "kim")
        {
            GameControlScript.health -= 1;

            co.GetComponent<move>().PlayerTakesDamage();
            
        }
        if(co.tag == "bomb"){
            Destroy(co.gameObject);
        }
    }

    public void BossTakesDamage()
    {
        StartCoroutine("BossFlasher");
    }




    public IEnumerator BossFlasher()
    {
        for (int i = 0; i <= 8; i++)
        {

            GameObject.Find("boss_16").GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);
            yield return new WaitForSeconds(.1f);
            GameObject.Find("boss_16").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            yield return new WaitForSeconds(.1f);
        }
    }
}
