using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runForestRun : MonoBehaviour {
 
    public float velocity=1;
    private Transform tr;

	// Use this for initialization
	void Start () {

        

        tr = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {

      

        tr.position += Vector3.right * Time.deltaTime * velocity;

    }
}
