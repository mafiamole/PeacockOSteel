using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    public GameObject ScoreText;
    public GameObject Player;

    

    public int ScoreValue;
	// Use this for initialization
	void Start () {
		
	}
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("(Collectable) OnControllerColliderHit " + hit.gameObject.name);

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("(Collectable) OnControllerColliderHit " + collision.gameObject.name);
        if (collision.gameObject.name == Player.name)
        {
            ScoreDisplay score = ScoreText.GetComponent<ScoreDisplay>();
            score.CurrentScore += ScoreValue;
            
            Destroy(this.gameObject,0);
            
        }
    }
    // Update is called once per frame
    void Update () {

	}
}
