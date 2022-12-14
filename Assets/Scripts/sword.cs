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
    gameManager gm;
    GameObject door;

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
            sound.gaurdexpo.Stop();
            opendoor();
        }
    }
    private void Start()
    {
        hitbox.enabled = false;
        player = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
        bloodsystem = bloodSplat.GetComponent<ParticleSystem>();
        sound = GameObject.Find("GameManager").GetComponent<Sfx>();
        gm = GameObject.Find("GameManager").GetComponent<gameManager>();
        door = GameObject.Find("door");
        door.transform.position = new Vector3(21.7490005f, -9.18999958f, -20.6499996f);
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

    public void opendoor()
    {
        door.transform.position = new Vector3(21.7490005f, -7.67000008f, -20.6499996f);
    }
}
