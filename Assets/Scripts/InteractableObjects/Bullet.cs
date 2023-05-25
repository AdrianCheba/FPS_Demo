using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Interactable
{
    GameObject weapon;
    int maxAmmo;


   public void FillAmmo()
    {
        weapon = GameObject.FindWithTag("Weapon");
        maxAmmo = weapon.GetComponent<WeaponReload>().maxAmmo;

        weapon.GetComponent<WeaponsData>().ammo = maxAmmo;
        gameObject.SetActive(false);
    }
}
