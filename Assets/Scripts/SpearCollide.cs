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
        Debug.Log("(SpearCollide) Collision with " + hit.gameObject.name);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Opponent")
        {
            ScoreDisplay scoreDisplay = ScoreDisplay.GetComponent<ScoreDisplay>();
            EnemyCollide enemyCollide = collision.gameObject.GetComponent<EnemyCollide>();
            enemyCollide.pointsOfGeneralHealthAndWellbeing -= 5;
            if (enemyCollide.pointsOfGeneralHealthAndWellbeing <= 0)
            {
                Destroy(collision.gameObject, 0);
                scoreDisplay.CurrentScore += 1000;
            }            
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
