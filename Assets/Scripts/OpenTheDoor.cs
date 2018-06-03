using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour {

    public Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Door Trigger enter: "+other.gameObject.tag);
        if ( other.gameObject.tag == "Player")
        {
            anim.Play("LeDoorAnimation");
        }
        
    }
    // Update is called once per frame
    void Update()
    {
    }
}
