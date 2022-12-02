using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class besttimes : MonoBehaviour
{
    [Header("refrences")]
    gameManager gm;
    public TextMeshProUGUI bestTimeLvl1Text;
    public GameObject besttime1;

    // Update is called once per frame
    void Update()
    {
        gm = GameObject.Find("GameManager").GetComponent<gameManager>();

        if (gm.besttimelvl1 > 9999999)
        {
            besttime1.active = false;
        }
        else
        {
            besttime1.active = true;
        }

        bestTimeLvl1Text.text = gm.besttimelvl1.ToString("0.000");
    }
}
