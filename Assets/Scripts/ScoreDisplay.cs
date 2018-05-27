using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    private int currentScore;
    public int CurrentScore
    {
        get { return currentScore; }
        set {  currentScore = value; UpdateText(); }
    }
	// Use this for initialization
	void Start () {
        currentScore = 0;
        
	}
    private void UpdateText()
    {
        Text value = gameObject.GetComponent<Text>();        
        value.text = "Score : " + currentScore.ToString();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
