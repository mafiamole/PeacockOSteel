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
    private void OnCollisionEnter(Collision collision)
    {
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
