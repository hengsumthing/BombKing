using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluemonster2 : MonoBehaviour
{
    public float movespeed = 3f;
    Transform patrolpoint1a, patrolpoint2a, patrolpoint3;
    Vector3 localscale;
    bool moveright = true;
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        localscale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        patrolpoint1a = GameObject.Find("patrolpoint2a").GetComponent<Transform>();
        patrolpoint2a = GameObject.Find("patrolpoint1a").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > patrolpoint2a.position.x)
            moveright = false;
        if (transform.position.x < patrolpoint1a.position.x)
            moveright = true;


        if (moveright)
            movingright();
        else
            movingleft();

    }
    void movingright()
    {
        moveright = true;
        localscale.x = 8;
        transform.localScale = localscale;
        rb.velocity = new Vector2(localscale.x * movespeed, rb.velocity.y);

    }
    void movingleft()
    {
        moveright = false;
        localscale.x = -8;
        transform.localScale = localscale;
        rb.velocity = new Vector2(localscale.x * movespeed, rb.velocity.y);

    }
}

