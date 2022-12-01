using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    [Header("Refrences")]
    public int startEnemys;
    public int enemysToKill;
    GameObject door;
    GameObject lvlfin;
    public static gameManager Instance;
    Timedscore ts;

    [Header("lvl settings")]
    public float besttimelvl1;


    // Start is called before the first frame update
    void Start()
    {
        int currentEnemys = GameObject.FindGameObjectsWithTag("Enemy").Length;
        ts = GameObject.Find("UI manaager").GetComponent<Timedscore>();
        door = GameObject.Find("door");
        lvlfin = GameObject.Find("finish");
        startEnemys = currentEnemys;
        door.transform.position = new Vector3(21.7490005f, -9.18999958f, -20.6499996f);
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

    public void opendoor()
    {
        door.transform.position = new Vector3(21.7490005f, -7.67000008f, -20.6499996f);
    }

    public void lvlend()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }
}
