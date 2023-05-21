using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsData : MonoBehaviour
{
    public string weaponName;
    public float damage;
    public float fireRate;
    public float reloadTime;
    public bool reloading;
    public string aspect1;
    public string aspect2;
    public string powerUP;

    public void WeaponName()
    {
        weaponName = gameObject.name;
    }
}
