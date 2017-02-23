using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runForestRun : MonoBehaviour {
 
    public float velocity=100;
    public float velocityGain = 0.1f;
    private Transform tr;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        rb = gameObject.GetComponent<Rigidbody2D>();

        tr = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {


        rb.velocity = new Vector2(velocity, rb.velocity.y);

       velocity = velocity + velocity * velocityGain*Time.deltaTime;

        //tr.position += Vector3.right * Time.deltaTime * velocity;

    }
}
