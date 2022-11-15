using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    [Header("Refrences")]
    Movement player;
    public BoxCollider hitbox;

    [Header("Key Binds")]
    public KeyCode attack = KeyCode.Mouse0;


    
    private void OnTriggerEnter(Collider enemy)
    {
        if(enemy.gameObject.tag == "Enemy")
        {
            enemy.attachedRigidbody.AddForce(0, 10, 0);
            //kill enemy
            Destroy(enemy.gameObject); //place holder should play animation
        }
        if(enemy.gameObject.tag == "Start enemy")
        {
            enemy.attachedRigidbody.AddForce(0, 10, 0);
            player.lvlstart = true;
            //kill enemy
            Destroy(enemy.gameObject); //place holder should play animation
        }
    }
    private void Start()
    {
        hitbox.enabled = false;
        player = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
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
