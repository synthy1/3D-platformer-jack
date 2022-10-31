using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timedscore : MonoBehaviour
{
    [Header("refrences")]
    gamemaneger game;
    public Text score;
    float currenttime;
    float timetaken;
    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("GameManager").GetComponent<gamemaneger>();
        currenttime = 0f;
        timetaken = 0f;
    }


    // Update is called once per frame
    void Update()
    {
        currenttime += Time.deltaTime;
        score.text = currenttime.ToString("Time: 0.000");
        if(game.enemyCount != 0)
        {
            //find time taken to kill all enemys
            timetaken = currenttime;
        }
    }
}
