using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timedscore : MonoBehaviour
{
    [Header("refrences")]
    public Text score;
    float timestart;
    Movement player;
    // Start is called before the first frame update
    void Start()
    {
        timestart = 0f;
        player = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
    }


    // Update is called once per frame
    void Update()
    {
        if (player.lvlstart)
        {
            timestart += Time.deltaTime;

            score.text = timestart.ToString("Time: 0.000");
        }
    }
}
