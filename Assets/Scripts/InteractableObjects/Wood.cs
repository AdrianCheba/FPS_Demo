using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wood : Interactable
{
    public GameObject weapon;
    public GameObject player;

    private DestroyInterface[] scripts;
    private List<DestroyInterface> destroyEffects = new();
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        maxHP = 100f;
        currentHP = 100f;

        scripts = GetComponents<DestroyInterface>();

        foreach (DestroyInterface obj in scripts)
        {

            AddEffects(obj);
        }

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
                MakeEffects();
                gameObject.SetActive(false);
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

    public void AddEffects(DestroyInterface effect)
    {
        destroyEffects.Add(effect);
    }

    public void MakeEffects()
    {
        foreach (var effect in destroyEffects)
        {
            effect.MakeEffect();
        }
    }
}
