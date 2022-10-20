using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    private void OnTriggerEnter(Collider enemy)
    {
        if(enemy.gameObject.tag == "Enemy")
        {
            //kill enemy
            Destroy(enemy.gameObject); //place holder should play animation
        }
    }
}
