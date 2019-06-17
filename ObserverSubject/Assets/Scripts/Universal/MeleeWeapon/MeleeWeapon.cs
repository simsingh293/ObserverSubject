using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : MonoBehaviour
{
    [Header("Weapon Attributes")]
    public float _AttackPower = 10.0f;

    [Header("Weapon Parts")]
    public SwordManager _Manager;
    public Animator _anim;

    

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _anim.SetTrigger("Swing1");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _anim.SetTrigger("Swing2");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _anim.SetTrigger("Swing3");
        }
    }
}
