using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemycounter : MonoBehaviour
{
    [Header("Refrenses")]
    gameManager game;
    public Text enemyText;
    string enemyDisplay;


    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        enemyText.text = game.enemysToKill.ToString("0/") + game.startEnemys.ToString("0");
    }
}
