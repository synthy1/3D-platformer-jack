using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedcounter : MonoBehaviour
{
    [Header("Refrences")]
    Movement player;
    public Text speed;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        speed.text = player.moveSpeed.ToString("Speed: 0");
    }
}
