using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerInRange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player in collider");
            AICharacterControl cltr = gameObject.GetComponent<AICharacterControl>();
            cltr.target = other.gameObject.transform;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Not in collider");
            AICharacterControl cltr = gameObject.GetComponent<AICharacterControl>();
            cltr.target = null;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
