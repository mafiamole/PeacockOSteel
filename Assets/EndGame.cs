using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

    public GameObject TextToShow;
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if ( other.tag == "Player" )
        {
            TextToShow.gameObject.SetActive(true); 
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
