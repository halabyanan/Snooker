﻿using UnityEngine;
using System.Collections;

public class SnookerBallController : MonoBehaviour
{
    public GameObject redBalls;
    public GameObject cueBall ;
    private Rigidbody rb;
    Vector3 center = new Vector3(-112,98,-16);
    private int flag = 0 ;
   /* public SnookerBallController(MonoBehaviour parent)
        : base(parent)
    {
        gameController = (PoolGameController)parent;
        redBalls = gameController.redBalls;
    }*/
	void Start() {
        rb = GetComponent<Rigidbody>();
        rb.sleepThreshold = 0.15f;

       
	}

    void OnCollisionEnter(Collision collided)
    {
        
       //  CueBall = GetComponent<GameObject>();

       /* if (collided.gameObject.name == "pSphere3")
        {
            rb.AddForce(center);
           // Physics.gravity = new Vector3(0f, 0f, 5f);
            //dostuff
        }
        if (collided.gameObject.name == "pSphere4")
        {

            rb.AddForce((center - transform.position).normalized * 10);
          //  Physics.gravity = new Vector3(0f, 0f, -5f);
            //dostuff
        }

        if (collided.gameObject.name == "table")
        {
        //    Physics.gravity = new Vector3(0f, 0f, 0f);
      //      rb.AddForce((GameObject.Find("table").transform.position - transform.position).normalized * 10);
       //     rb.AddForce(center * 10);
            //dostuff
        }
       



     //   Vector3 v = table.bounds.center;
        int a = 0;*/
    }

	void FixedUpdate () {
       
       // Vector3 force = new Vector3(5,5,5);
        if (rb.name == "CueBall")
        {
            var a = 1; //// :)
        }
        else
        {
            rb.AddForce((center - transform.position).normalized * 10);
        }
 
		var rigidbody = GetComponent<Rigidbody>();
		if (rigidbody.velocity.y > 0) {
			var velocity = rigidbody.velocity;
            
         
      /*      var pos = rigidbody.position;
            pos.x = redBalls.transform.position.x; //////////להמשיך מפה
            rigidbody.position = pos;
            */
			velocity.y *= 1.03f;
          //  velocity.x *= 0.2f;
			rigidbody.velocity = velocity;
		}

        if (rigidbody.velocity.x > 0)
        {
            var velocity = rigidbody.velocity;


            /*      var pos = rigidbody.position;
                  pos.x = redBalls.transform.position.x; //////////להמשיך מפה
                  rigidbody.position = pos;
                  */
            velocity.x *= 1.03f;
            //  velocity.x *= 0.2f;
            rigidbody.velocity = velocity;
        }

        if (rigidbody.velocity.z > 0)
        {
            var velocity = rigidbody.velocity;


            /*      var pos = rigidbody.position;
                  pos.x = redBalls.transform.position.x; //////////להמשיך מפה
                  rigidbody.position = pos;
                  */
            velocity.z *= 1.03f;
            //  velocity.x *= 0.2f;
            rigidbody.velocity = velocity;
        }
	}
}
