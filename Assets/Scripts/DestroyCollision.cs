﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        
    }
    // Update is called once per frame
    void Update () {
		
	}
}
