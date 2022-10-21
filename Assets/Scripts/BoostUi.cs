using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostUi : MonoBehaviour
{
    [Header("Refrences")]
    Movement PlayerMovement;
    public Image UIBoost;



    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.boosting == true)
        {
            UIBoost.gameObject.SetActive(true);
            Debug.Log("ui");
        }

        else
        {
            UIBoost.gameObject.SetActive(false);
        }
    }
}
