using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timedscore : MonoBehaviour
{
    [Header("refrences")]
    public Text score;
    public TextMeshProUGUI finalscore;
    float timestart;
    gameManager GM;

    [SerializeField]
    private TextMeshProUGUI bestruntime;
    float runTime;


    Movement player;
    // Start is called before the first frame update
    void Start()
    {
        timestart = 0f;
        Time.timeScale = 1f;
    }


    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
        GM = GameObject.Find("GameManager").GetComponent<gameManager>();
        if (player.lvlstart)
        {
            timestart += Time.deltaTime;
            runTime = timestart;
            score.text = timestart.ToString("Time: 0.000");
        }

        if (player.lvlend)
        {
            runTime = timestart;
            finalscore.text = runTime.ToString("This Run: 0.000");
            

            if (GM.besttimelvl1 >= runTime)
            {
                GM.besttimelvl1 = runTime;
            }

            bestruntime.text = GM.besttimelvl1.ToString("Best Run: 0.000");
        }
        Debug.Log(runTime);
    }
}
