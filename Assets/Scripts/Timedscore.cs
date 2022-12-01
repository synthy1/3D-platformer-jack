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

    [SerializeField]
    private float besttimelvl1;


    Movement player;
    // Start is called before the first frame update
    void Start()
    {
        timestart = 0f;
        player = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
        GM = GameObject.Find("GameManager").GetComponent<gameManager>();
        Time.timeScale = 1f;
    }


    // Update is called once per frame
    void Update()
    {
        if (player.lvlstart)
        {
            timestart += Time.deltaTime;

            score.text = timestart.ToString("Time: 0.000");
        }
        if (player.lvlend)
        {
            runTime = timestart;
            finalscore.text = runTime.ToString("This Run: 0.000");
            

            if (besttimelvl1 >= runTime)
            {
                GM.besttimelvl1 = runTime;
            }
            else
            {
                GM.besttimelvl1 = besttimelvl1;
            }
            bestruntime.text = GM.besttimelvl1.ToString("Best Run: 0.000");
        }
        Debug.Log(besttimelvl1);
    }
}
