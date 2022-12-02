using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    [Header("Refrences")]
    public int startEnemys;
    public int enemysToKill;
    GameObject lvlfin;
    public static gameManager Instance;
    Timedscore ts;

    [Header("lvl settings")]
    public float besttimelvl1;


    // Start is called before the first frame update
    void Start()
    {
        //lvl
        besttimelvl1 = 9999999999;


        int currentEnemys = GameObject.FindGameObjectsWithTag("Enemy").Length;
        ts = GameObject.Find("UI manaager").GetComponent<Timedscore>();
        lvlfin = GameObject.Find("finish");
        startEnemys = currentEnemys;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        int currentEnemys = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemysToKill = startEnemys - currentEnemys;
    }

    public void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public void lvlend()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }
}
