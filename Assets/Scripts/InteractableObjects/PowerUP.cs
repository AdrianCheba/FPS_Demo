using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : Interactable
{
    private GameObject pistol;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            pistol = GameObject.FindGameObjectWithTag("Weapons");

            if (pistol.name == "Pistol")
            {
                pistol.GetComponent<WeaponsData>().powerUP = this.gameObject.name;
                this.gameObject.SetActive(false);
            }
        }
    }
}
