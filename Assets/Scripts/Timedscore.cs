using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timedscore : MonoBehaviour
{
    [Header("refrences")]
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = 0.ToString("0");
    }


    // Update is called once per frame
    void Update()
    {
        

        score.text += Time.deltaTime.ToString("f0");
    }
}
