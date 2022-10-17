using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementscript : MonoBehaviour
{
    public CharacterController characterController;
    public Transform cam;

    public float turnsmoothtime = 0.5f;
    public float turnsmoothspeed;
    //variables used for movement
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float virtical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, virtical);

        //movement
        if (direction.magnitude > 0.1)
        {
            float targetangle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetangle, ref turnsmoothtime, turnsmoothspeed);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 movedri = Quaternion.Euler(0f, targetangle, 0f) * Vector3.forward;
            characterController.Move(movedri.normalized * speed * Time.deltaTime);
        }
    }
}
