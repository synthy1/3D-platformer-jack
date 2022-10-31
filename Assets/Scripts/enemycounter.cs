using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemycounter : MonoBehaviour
{

    [Header("Refrences")]
    gamemaneger game;
    public Text enemytotal;

    private string score;
    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("GameManager").GetComponent<gamemaneger>();
    }

    // Update is called once per frame
    void Update()
    {
        score = (game.enemysToKill.ToString("0/") + game.toatalEnemys.ToString());
        enemytotal.text = score;
    }
}
