using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Interactable
{
    public GameObject weapon;
    public GameObject player;
    public bool interact = true;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    protected override void Interact()
    {
        weapon = GameObject.FindGameObjectWithTag("Weapon");

        if (weapon.GetComponent<WeaponsData>().aspect1 == "fire" || weapon.GetComponent<WeaponsData>().aspect2 == "fire" || weapon.GetComponent<WeaponsData>().powerUP == "Fire PowerUP")
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
             Invoke("ClearHelpText", 1);
        }

    }

    void ClearHelpText()
    {
        player.GetComponent<PlayerUI>().UpdateHelpText(string.Empty);
    }
}
