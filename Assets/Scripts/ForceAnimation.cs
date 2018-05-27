using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceAnimation : MonoBehaviour {

    // Use this for initialization
    int forwardParameterIndex;
	void Start () {
        int i = 0;
        foreach (var parameter in GetComponent<Animator>().parameters)
        {
            if (parameter.name == "forward" )
            {
                
                this.forwardParameterIndex = i;
            }
            i++;
        }
    }
	
	// Update is called once per frame
	void Update () {
        Animator animator = GetComponent<Animator>();
        
        if (Input.GetKey(KeyCode.W))
        {
            
            animator.Play("walk");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.Play("walkBackwards");
        }
        else
        {
            animator.Play("idle");
        }
    }
}
