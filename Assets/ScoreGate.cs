using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGate : MonoBehaviour {

    public GameObject BigDoor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (BallController.score == 8)
        {
            BigDoor.SetActive(false);
        }
	}
}
