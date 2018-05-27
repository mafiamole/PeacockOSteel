using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollect : MonoBehaviour {

    public Collider Weapon;
    public int pointsOfGeneralHealthAndWellbeing;
    public Text pointsOfGeneralHealthAndWellbeingDisplay;
    // Use this for initialization
    void Start () {
		
	}
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Collectable")
        {
            Debug.Log("(PlayerCollect) OnControllerColliderHit with " + hit.gameObject.name);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.tag == "Weapon")
        {
            Debug.Log("(PlayerCollect) Damage received");
            pointsOfGeneralHealthAndWellbeing -= 5;
            pointsOfGeneralHealthAndWellbeingDisplay.text = "Points of General Health and Well Being : " + pointsOfGeneralHealthAndWellbeing;
        }
    }
    // Update is called once per frame
    void Update () {
		if ( pointsOfGeneralHealthAndWellbeing <=0)
        {
            Debug.Log("(PlayerCollect) The player is no more");
            Destroy(this.gameObject);
        }
	}
}
