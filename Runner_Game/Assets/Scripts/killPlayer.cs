using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class killPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<MeshRenderer>().enabled = false;

            Invoke("Restart", 2.0f);
        }

        Debug.Log("Collided death");
    }

    void Restart()
    {

        Scene selfScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("levelController");

    }
}
