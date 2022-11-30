using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    [Header("Refrences")]
    public int startEnemys;
    public int enemysToKill;
    public GameObject door;
    public GameObject lvlfin;
    public static gameManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        int currentEnemys = GameObject.FindGameObjectsWithTag("Enemy").Length;
        startEnemys = currentEnemys;
        door.transform.position = new Vector3(21.7490005f, -9.18999958f, -20.6499996f);
        lvlfin.active = false;
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
        lvlfin.active = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }
}
