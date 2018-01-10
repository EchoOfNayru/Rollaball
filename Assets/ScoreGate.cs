using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGate : MonoBehaviour {

    public GameObject BigDoor;
    Vector3 moveTo;
    public float lerpTime;

	// Use this for initialization
	void Start () {
        moveTo = transform.position + (Vector3.up * 5);
	}
	
	// Update is called once per frame
	void Update () {
        if (BallController.score == 8)
        {
            transform.position = Vector3.Lerp(transform.position, moveTo, lerpTime * Time.deltaTime);
        }
	}
}
