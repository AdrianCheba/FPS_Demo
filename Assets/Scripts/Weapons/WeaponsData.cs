using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsData : MonoBehaviour
{
    public string weaponName;
    public float damage;
    public int ammo = 8;
    public float reloadTime = 1;
    public string aspect1;
    public string aspect2;
    public string powerUP;

    public void WeaponName()
    {
        weaponName = gameObject.name;
    }
}
