using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour {

    public GameObject collectible1;
    public GameObject collectible2;
    public GameObject collectible3;
    public GameObject collectible4;
    public GameObject collectible5;
    public GameObject collectible6;
    public GameObject collectible7;
    public GameObject collectible8;
    public GameObject ScoreGate;

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
            BallController.score = 0;
            collectible1.SetActive(true);
            collectible2.SetActive(true);
            collectible3.SetActive(true);
            collectible4.SetActive(true);
            collectible5.SetActive(true);
            collectible6.SetActive(true);
            collectible7.SetActive(true);
            collectible8.SetActive(true);
            ScoreGate.SetActive(true);
        }
    }
}
