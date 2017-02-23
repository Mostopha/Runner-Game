using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 _rayPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D _rayHit = Physics2D.Raycast(new Vector2(_rayPosition.x, _rayPosition.y), Camera.main.transform.forward);
            Debug.Log(_rayHit.collider.name);

            switch (_rayHit.collider.tag)
            {
                case "fall":

                    _rayHit.collider.GetComponent<Rigidbody2D>().gravityScale = 8;

                    //_rayHit.collider.transform.position = Vector3.MoveTowards(_rayHit.collider.transform.position, new Vector3(_rayHit.collider.transform.position.x, _rayHit.collider.transform.position.y - 3, _rayHit.collider.transform.position.z), 0.5f);

                    break;

            }
        }

     
    }
}
