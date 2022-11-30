using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{

    [Header("refrences")]
    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;
    public Camera menucam;
    int current;

    [Header("Vectors")]
    Vector3 camPos;
    Vector3 startCamPos;
    private void Start()
    {
        camPos = menucam.transform.position;
        startCamPos = menucam.transform.position;

        //makes sure menu one is open first
        menu1.active = true;
        menu2.active = false;
        
    }
    private void Update()
    {
        current = SceneManager.GetActiveScene().buildIndex;
    }
    public void ExitGame()
    {
        Application.Quit(); //quits application
    }

    public void OpenMenu2()
    {
        menu1.active = false; //hides current menu
        menu2.active = true;
    }

    public void Credits()
    {

    }

    public void Settings()
    {
        menu1.active = false; //hides current menu
    }

    public void ReturnFromLvlSlc()
    {
        menu1.active = true; 
        menu2.active = false;//hides current menu
    }

    public void lvl1()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    } 
    public void Retry()
    {
        SceneManager.LoadScene(current);
    }
}
