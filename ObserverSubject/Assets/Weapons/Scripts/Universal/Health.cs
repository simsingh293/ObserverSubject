using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int _CurrentHealth;
    public int _MaxHealth = 100;


    // Start is called before the first frame update
    void Start()
    {
        _CurrentHealth = _MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        WithinLimits();
    }

    public void AddHealth(int value)
    {
        int x = _CurrentHealth + value;

        if(x > _MaxHealth)
        {
            _CurrentHealth = _MaxHealth;
        }
        else
        {
            _CurrentHealth += value;
        }
    }

    public void DeductHealth(int value)
    {
        int x = _CurrentHealth - value;

        if(x < 0)
        {
            _CurrentHealth = 0;
        }
        else
        {
            _CurrentHealth -= value;
        }
    }


    void WithinLimits()
    {
        if(_CurrentHealth < 0)
        {
            _CurrentHealth = 0;
        }

        if(_CurrentHealth > _MaxHealth)
        {
            _CurrentHealth = _MaxHealth;
        }
    }
}
