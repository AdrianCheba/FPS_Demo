using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBarrel : Interactable
{
    public GameObject weapon;
    public GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        maxHP = 75f;
        currentHP = 75f;
    }
    protected override void Interact()
    {
        weapon = GameObject.FindGameObjectWithTag("Weapon");

        if (weapon.GetComponent<WeaponsData>().aspect1 == "Fire" || weapon.GetComponent<WeaponsData>().aspect2 == "Fire" || weapon.GetComponent<WeaponsData>().powerUP == "Fire PowerUP")
        {
            currentHP -= weapon.GetComponent<WeaponsData>().damage;
            weapon.GetComponent<WeaponsData>().ammo--;

            if (currentHP <= 0)
            {
                this.gameObject.SetActive(false);
            }
        }
        else
        {
             player.GetComponent<PlayerUI>().UpdateHelpText("This weapon can't destroy that target ");
             Invoke("ClearHelpText", 1);
        }

    }

    void ClearHelpText()
    {
        player.GetComponent<PlayerUI>().UpdateHelpText(string.Empty);
    }
}
