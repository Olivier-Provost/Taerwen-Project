using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehavior : MonoBehaviour
{


    GameObject objToDestroy;
    bool canKill = false;


    void Update()
    {
        if (Input.GetButtonDown("Attack") && canKill)
        {
            Destroy(objToDestroy);
            canKill = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Slime"))
        {
            objToDestroy = collider.gameObject;
            canKill = true;
        }
    }
}