using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    [Header("References")]
    public Transform orient;
    public Transform Player;
    public Transform Player_obj;
    public Rigidbody rbody;
    private Movement PlayerMovement;
    public Cinemachine.CinemachineFreeLook camSettings;

    [Header("Boost Managment")]
    private float rotationSpeed;
    public float boostRotationSpeed;
    public float normRotationSpeed;

    
    [Header("Fov Settings")]
    public float normalFov;
    private float boostFov;
    private float currentFov;
    private int roundedcurrentFov;
    private float fovChangeRate = 0.05f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PlayerMovement = GameObject.Find("Thirdperson_Character").GetComponent<Movement>();
        boostFov = normalFov + 10f;
        currentFov = normalFov;
        roundedcurrentFov = (int)normalFov;
    }

    private void Update()
    {
        if(PlayerMovement.boosting == true)
        {
            //caracter rotation to match speed of boost
            rotationSpeed = boostRotationSpeed;

            //transitions fov instead of instant fov change
            if (roundedcurrentFov != boostFov)
            {
                roundedcurrentFov = (int)(currentFov += fovChangeRate);
            }
            camSettings.m_Lens.FieldOfView = roundedcurrentFov;
        }

        else
        {
            //normal caracter rotation
            rotationSpeed = normRotationSpeed;

            //transitions fov instead of instant fov change
            if(roundedcurrentFov != normalFov)
            {
                roundedcurrentFov = (int)(currentFov -= fovChangeRate);
            }
            camSettings.m_Lens.FieldOfView = roundedcurrentFov;
        }

        //rotate orientation
        Vector3 veiwDir = Player.position - new Vector3(transform.position.x, Player.position.y, transform.position.z);
        orient.forward = veiwDir.normalized;

        //rotate player
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector3 inputDir = orient.forward * verticalInput + orient.right * horizontalInput;

        if(inputDir!= Vector3.zero)
        {
            Player_obj.forward = Vector3.Slerp(Player_obj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
        }
    }
}
