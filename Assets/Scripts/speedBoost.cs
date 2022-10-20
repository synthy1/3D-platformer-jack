using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedBoost : MonoBehaviour
{

    [Header("Refrences")]
    Movement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
    }
    
    private void OnTriggerEnter(Collider boostPickup)
    {
        //checking for collition
        if (boostPickup.gameObject.tag == "Player")
        {
            //starts boosting
            playerMovement.BoostStart();

            //destroys pickup
            Destroy(gameObject);
            Debug.Log("pickup!");
        }
    }

}
