using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlend : MonoBehaviour
{
    [Header("refrenses")]
    Movement player;
    gameManager game;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
        game = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && game.startEnemys == game.enemysToKill)
        {
            player.lvlend = true;
        }
    }
}
