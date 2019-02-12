using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums
{
    
    public enum EffectType
    {
        slashing, 
        blunt, 
        piercing, 
        poison, 
        fire, 
        cold, 
        lightning, 
        healing,
        slow, 
        speed,
        nightVision,
        statUp,
        statDown,
        resist,
    }
	
    public enum WeaponType
    {
        sword, 
        axe, 
        mace, 
        hammer,
        whip, 
        magicalProjectile, 
        bow,
        staff,
        magicalAOE,

    }

    public enum ItemType
    {
        weapon, 
        shield,
        wearable,
        questItem,
        misc, 
        edible,
        material,
        
    }

    public enum Race
    {
        humanoid, 
        animal,
        beast,
        none,

    }

}
