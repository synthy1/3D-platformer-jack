using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemaneger : MonoBehaviour
{

    [Header("refrenses")]
    public int toatalEnemys;
    public int enemysToKill;
    public int enemyCount;



    // Start is called before the first frame update
    void Start() 
    {
        int currentEnemys = GameObject.FindGameObjectsWithTag("Enemy").Length;
        toatalEnemys = currentEnemys;
    }

    // Update is called once per frame
    void Update()
    {
        int currentEnemys = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemysToKill = toatalEnemys - currentEnemys;
        enemyCount = currentEnemys;
    }
    
}
