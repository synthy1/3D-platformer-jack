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

    [Header("Vectors")]
    Vector3 camPos;
    Vector3 startCamPos;
    private void Start()
    {
        camPos = menucam.transform.position;
        startCamPos = menucam.transform.position;
        
    }
    public void ExitGame()
    {
        Application.Quit(); //quits application
    }

    public void OpenMenu2()
    {
        menu1.active = false; //hides current menu

    }

    public void Credits()
    {

    }

    public void Settings()
    {
        menu1.active = false; //hides current menu
    }
}
