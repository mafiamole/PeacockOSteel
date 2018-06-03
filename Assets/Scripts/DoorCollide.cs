using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollide : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Weapon")
        {
            Destroy(this.gameObject);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Weapon")
        {
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
