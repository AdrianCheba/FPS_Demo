using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Concrete : Interactable
{
    public GameObject weapon;
    public GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        maxHP = 120f;
        currentHP = 120f;
    }
    protected override void Interact()
    {
        weapon = GameObject.FindGameObjectWithTag("Weapon");

        if (weapon.GetComponent<WeaponsData>().aspect1 == "Concrete" || weapon.GetComponent<WeaponsData>().aspect2 == "Concrete")
        {
            currentHP -= weapon.GetComponent<WeaponsData>().damage;

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
