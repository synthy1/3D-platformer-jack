using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvlend : MonoBehaviour
{
    [Header("refrenses")]
    Movement player;
    gameManager game;
    public GameObject uiEnd;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
        game = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

    private void Update()
    {
        if (player.lvlend)
        {
            game.lvlend();
            uiEnd.active = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && game.startEnemys == game.enemysToKill)
        {
            player.lvlend = true;
        }
    }

}
