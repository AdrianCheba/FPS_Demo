using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardboardEnemy: Interactable
{
    public GameObject weapon;
    public GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        maxHP = 50f;
        currentHP = 50f;
    }
    protected override void Interact()
    {
        weapon = GameObject.FindGameObjectWithTag("Weapon");

      

        if (weapon.GetComponent<WeaponsData>().aspect1 == "Cardboard" || weapon.GetComponent<WeaponsData>().aspect2 == "Cardboard")
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
