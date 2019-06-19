using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Subject _Unit = collision.gameObject.GetComponent<Subject>();
            _Unit._Player = gameObject;
            _Unit._IsAttacked = true;
        }
    }

}