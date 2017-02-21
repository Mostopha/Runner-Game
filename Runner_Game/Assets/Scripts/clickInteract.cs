using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickInteract : MonoBehaviour {
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        rb.gravityScale = 1;
        Debug.Log("It works");
    }
}
