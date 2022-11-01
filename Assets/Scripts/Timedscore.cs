using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timedscore : MonoBehaviour
{
    [Header("refrences")]
    public Text score;
    float timestart;
    // Start is called before the first frame update
    void Start()
    {
        timestart = 0f;
    }


    // Update is called once per frame
    void Update()
    {
        timestart += Time.deltaTime;

        score.text = timestart.ToString("Time: 0.000");
    }
}
