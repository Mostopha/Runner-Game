using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickHinge : MonoBehaviour {
    public HingeJoint2D hingey;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        hingey.useMotor = false;
        Debug.Log("It works");
    }
}
