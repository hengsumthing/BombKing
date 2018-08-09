using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public static  float speed = 7;
    public static bool facingRight = true;
    public static bool directionL, directionR, directionU, directionD = false;
  
    public GameObject crossexplosion;
    // Use this for initialization
    void Start () {
		
	}
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
        //    bbombcontroller.bbomb -= 1;
        //    GetComponent<BombDrop2>();
        //    GetComponent<timer>();
        //    timer.maxtime += 6;
        //    timer.timeleft += 6;
        Instantiate(crossexplosion, transform.position, Quaternion.identity);

        }
    
        if(Input.GetKeyDown(KeyCode.Space))
        {
            sbombcontroller.smbomb -= 1;
            GetComponent<Bombdrop>();
            GetComponent<timer>();
            timer.maxtime += 3;
            timer.timeleft += 3;
        }
     //check direction
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            //Debug.Log("Left");
            directionU = false;
            directionD = false;
            directionL = true;
            directionR = false;

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            directionU = false;
            directionD = false;
            directionL = false;
            directionR = true;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            directionU = true;
            directionD = false;
            directionL = false;
            directionR = false;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            directionU = false;
            directionD = true;
            directionL = false;
            directionR = false;
        }

        //move over bomb


            
    }

    

    // Update is called once per frame
    void FixedUpdate () {
        // Check Input Axes
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(h, v) * speed;

        GetComponent<Animator>().SetInteger("X", (int)h);
        GetComponent<Animator>().SetInteger("Y", (int)v);

        if (h > 0 && !facingRight) { Flip(); }
             
        else if (h < 0 && facingRight)
              { Flip(); }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
       // if (other.tag == "monster")

       //     GameControlScript.health -= 1;



    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;


    }

    public void PlayerTakesDamage()
    {
        StartCoroutine("PlayerFlasher");
    }

    public IEnumerator PlayerFlasher()
    {
        for (int i = 0; i <= 5; i++)
        {

            GameObject.Find("Player").GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);
            yield return new WaitForSeconds(.1f);
            GameObject.Find("Player").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            yield return new WaitForSeconds(.1f);
        }
    }
}
