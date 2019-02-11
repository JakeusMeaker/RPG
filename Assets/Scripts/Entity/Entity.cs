using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {

    public int health;
    public int armourValue;
    public int moveSpeed;
    public string name;

    public Item[] inventory;
    public Item[] equipped;

    public Enums.Race race;

    public void TakeDamage(int damage)
    {

    }

    public void HealDamage(int heal)
    {

    }

    public int GetHealth()
    {
        return 0;
    }

    public int GetArmourValue()
    {
        return 0;
    }

    public string GetName()
    {
        return null;
    }

    public Enums.Race GetRace()
    {
        return null;
    }

}
