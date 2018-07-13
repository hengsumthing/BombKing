using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour {
    public Transform[] patrolPoints;
    public float speed;
    Transform CurrentpatrolPoint;
    int currentPatrolIndex;

	// Use this for initialization
	void Start () {
        currentPatrolIndex = 0;
        CurrentpatrolPoint = patrolPoints[currentPatrolIndex];
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Time.deltaTime * speed); 
		if(Vector3.Distance(transform.position,CurrentpatrolPoint.position) > .1f)
        {
            if (currentPatrolIndex + 1 < patrolPoints.Length)
            {
                currentPatrolIndex++;
            }
            else
            {
                currentPatrolIndex = 0;
            }
            CurrentpatrolPoint = patrolPoints[currentPatrolIndex];

            Vector3 patrolPointDir = CurrentpatrolPoint.position - transform.position;
            float angle = Mathf.Atan2(patrolPointDir.y, patrolPointDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
           // transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180f);


        }
	}
}
