using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    [Header("Refrences")]
    public int startEnemys;
    public int enemysToKill;
    // Start is called before the first frame update
    void Start()
    {
        int currentEnemys = GameObject.FindGameObjectsWithTag("Enemy").Length;
        startEnemys = currentEnemys;
    }

    // Update is called once per frame
    void Update()
    {
        int currentEnemys = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemysToKill = startEnemys - currentEnemys;
    }
}
