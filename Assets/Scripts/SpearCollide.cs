using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearCollide : MonoBehaviour {

    public GameObject ScoreDisplay;
	// Use this for initialization
	void Start () {
		
	}
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        /*
        if (hit.gameObject.tag == "Collectable")
        {
            
        }
        */
        Debug.Log("(SpearCollide) Collision with " + hit.gameObject.name);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("(SpearCollide)  on collision enter!");
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Opponent")
        {
            Debug.Log("Boom!");
            ScoreDisplay scoreDisplay = ScoreDisplay.GetComponent<ScoreDisplay>();

            Destroy(collision.gameObject, 0);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
