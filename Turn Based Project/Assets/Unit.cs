using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLvl;

    public int damage;

    public int maxHP;
    public int currentHP;

    public bool TakeDamage(int damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
            return true;
        else
            return false;
    }

    public void Heal(int amout)
    {
        currentHP += amout;
        if (currentHP > maxHP)
            currentHP = maxHP;
    }
}
