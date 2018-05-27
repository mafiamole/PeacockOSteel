using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearCollide : MonoBehaviour {

    public GameObject ScoreDisplay;
	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Opponent")
        {
            ScoreDisplay scoreDisplay = ScoreDisplay.GetComponent<ScoreDisplay>();

            Destroy(collision.gameObject, 0);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
