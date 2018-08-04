using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour {
    public Transform target;
    public float speed;
    public static bool facingRight = true;

    public static float attacktimer = 5;
    public static float timeleft = 0;
    public GameObject bossattack;

    public static int bosshp = 2;

    // Use this for initialization
    void Start () {
        timeleft =attacktimer;
    }
	
	// Update is called once per frame
	void Update () {

        //hp
        if (bosshp == 0){
            Destroy(gameObject);
        }

        // movement
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);



        // flip
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(h, v) * speed;

        GetComponent<Animator>().SetInteger("X", (int)h);
        GetComponent<Animator>().SetInteger("Y", (int)v);
        

        if (h > 0 && !facingRight) { Flip(); }

        else if (h < 0 && facingRight)
        { Flip(); }

        //attack
        Vector2 pos = transform.position;
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            //Debug.Log(timeleft);
        }
        else if (timeleft <= 0)
        {
            Instantiate(bossattack, pos, Quaternion.identity);
            timeleft = attacktimer;
            
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;


    }
}
