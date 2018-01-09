using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 spawn = new Vector3(0, 9, 1);
            other.transform.position = spawn;
            BallController ballController = other.GetComponent<BallController>();
            ballController.rb.velocity = Vector3.zero;
        }
    }
}
