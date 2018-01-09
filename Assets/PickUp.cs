using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

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
            
            BallController ballController = other.GetComponent<BallController>();
            ballController.score += 1;
            Destroy(gameObject);
        }
    }

    //OnTriggerEnter(Collider other)

    //if the colliders tag is the player
    //Get the BallController componenet and add score

}
