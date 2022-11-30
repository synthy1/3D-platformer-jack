using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    [Header("Refrences")]
    Movement player;
    public BoxCollider hitbox;
    public GameObject bloodSplat;
    public Animator anim;
    Transform bloodLocation;
    ParticleSystem bloodsystem;
    Sfx sound;

    [Header("Key Binds")]
    public KeyCode attack = KeyCode.Mouse0;

    
    private void OnTriggerEnter(Collider enemy)
    {
        if(enemy.gameObject.tag == "Enemy")
        {
            bloodLocation = enemy.transform;
            bloodSplat.transform.position = bloodLocation.position;
            if(bloodSplat.transform.position == bloodLocation.position)
            {
                bloodsystem.Play();
                sound.PlayBlood();
            }
            //kill enemy
            Destroy(enemy.gameObject); //place holder should play animation
            sound.PlayDeath();
        }
        if(enemy.gameObject.tag == "Start enemy")
        {
            bloodLocation = enemy.transform;
            bloodSplat.transform.position = bloodLocation.position;
            if (bloodSplat.transform.position == bloodLocation.position)
            {
                bloodsystem.Play();
                sound.PlayBlood();
            }
            player.lvlstart = true;
            //kill enemy
            Destroy(enemy.gameObject); //place holder should play animation
            sound.PlayDeath();
            sound.gaurdexpo.Pause();
        }
    }
    private void Start()
    {
        hitbox.enabled = false;
        player = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
        bloodsystem = bloodSplat.GetComponent<ParticleSystem>();
        sound = GameObject.Find("GameManager").GetComponent<Sfx>();
    }

    private void Update()
    {
        //starts kill
        if (Input.GetKeyDown(attack))
        {
            sound.PlayHit();
            //sets off hitbox
            hitbox.enabled = true;


            //play attack animations
            anim.SetTrigger("attack");
        }

        //attack off after you let go of keybind
        if (Input.GetKeyUp(attack))
        {

            //disables hitbox
            hitbox.enabled = false;
        }
    }
}
