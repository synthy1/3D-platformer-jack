using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    private void OnTriggerEnter(Collision colidor)
    {
        if(colidor.tag == "Enemy")
        {
            //kill enemy
            colidor.destroy;
        }
    }
}
