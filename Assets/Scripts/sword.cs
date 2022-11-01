using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    [Header("Refrences")]
    public BoxCollider hitbox;

    [Header("Key Binds")]
    public KeyCode attack = KeyCode.Mouse0;


    
    private void OnTriggerEnter(Collider enemy)
    {
        if(enemy.gameObject.tag == "Enemy")
        {
            //kill enemy
            Destroy(enemy.gameObject); //place holder should play animation
        }
    }
    private void Start()
    {
        hitbox.enabled = false;
    }

    private void Update()
    {
        //starts kill
        if (Input.GetKeyDown(attack))
        {

            //sets off hitbox
            hitbox.enabled = true;
            
            //play attack animations
        }

        //attack off after you let go of keybind
        if (Input.GetKeyUp(attack))
        {

            //disables hitbox
            hitbox.enabled = false;
        }
    }
}
