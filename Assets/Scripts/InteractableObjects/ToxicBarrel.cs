using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodCrate: Interactable
{
    public GameObject weapon;
    public GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        maxHP = 100f;
        currentHP = 100f;
    }
    protected override void Interact()
    {
        weapon = GameObject.FindGameObjectWithTag("Weapon");

        if (weapon.GetComponent<WeaponsData>().aspect1 == "Wood" || weapon.GetComponent<WeaponsData>().aspect2 == "Wood")
        {
            currentHP -= weapon.GetComponent<WeaponsData>().damage;
            weapon.GetComponent<WeaponsData>().ammo--;
            weapon.GetComponent<WeaponShoot>().Shoot();

            if (currentHP <= 0)
            {
                this.gameObject.SetActive(false);
            }
        }
        else
        {
             player.GetComponent<PlayerUI>().UpdateHelpText("This weapon can't destroy that target ");
             Invoke("ClearHelpText", 0.75f);
        }

    }

    void ClearHelpText()
    {
        player.GetComponent<PlayerUI>().UpdateHelpText(string.Empty);
    }
}
