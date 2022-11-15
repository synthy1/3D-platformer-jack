using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class lvlstartui : MonoBehaviour
{
    [Header("refrenses")]
    Movement player;
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.lvlstart)
        {
            ui.gameObject.SetActive(false);
        }
        if (player.lvlstart)
        {
            ui.gameObject.SetActive(true);
        }
    }
}
