using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluemonster : MonoBehaviour {
    public static float movespeed = 3f;
    Transform patrolpoint1, patrolpoint2, patrolpoint3;
    Vector3 localscale;
    bool moveright = true;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        localscale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
       patrolpoint1 = GameObject.Find("patrolpoint2").GetComponent<Transform>();
       patrolpoint2 = GameObject.Find("patrolpoint1").GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > patrolpoint2.position.x)
            moveright = false;
        if (transform.position.x < patrolpoint1.position.x)
            moveright = true;
  

        if (moveright)
            movingright();
        else
            movingleft();
        
    }
    void movingright()
    {
        moveright = true;
        localscale.x = 1;
        transform.localScale = localscale;
        rb.velocity = new Vector2(localscale.x * movespeed, rb.velocity.y);

    }
    void movingleft()
    {
        moveright = false;
        localscale.x = -1;
        transform.localScale = localscale;
        rb.velocity = new Vector2(localscale.x * movespeed, rb.velocity.y);

    }
}
