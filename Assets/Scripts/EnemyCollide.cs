using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollide : MonoBehaviour {

    public Collider Weapon;
    public int pointsOfGeneralHealthAndWellbeing;
	// Use this for initialization
	void Start () {
		
	}
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Collectable")
        {
            Debug.Log("(EnemyCollect) OnControllerColliderHit with " + hit.gameObject.name);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Weapon" && Input.GetMouseButton(0))
        {

            pointsOfGeneralHealthAndWellbeing -= 30;
        }
    }
    // Update is called once per frame
    void Update () {
        if (pointsOfGeneralHealthAndWellbeing <= 0)
        {
            Debug.Log("(EnemyCollide) The enemy is no more");
            Destroy(this.gameObject);
        }
    }
}
