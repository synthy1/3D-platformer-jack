using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{

    [Header("refrences")]
    GameObject menu1;
    GameObject menu2;
    GameObject menu3;
    int current;

    [Header("Vectors")]
    Vector3 camPos;
    Vector3 startCamPos;
    private void Start()
    {
        menu1 = GameObject.Find("menu_1");
        menu2 = GameObject.Find("menu_2");
        menu3 = GameObject.Find("menu_3");

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
