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
            pistol = GameObject.FindGameObjectWithTag("Weapon");

            if (pistol.name == "Pistol")
            {
                pistol.GetComponent<WeaponsData>().powerUP = gameObject.name;
                this.gameObject.SetActive(false);
                Invoke("Restore", 3);
            }
        }
    }

    private void Restore()
    {
        this.gameObject.SetActive(true);
    }

}
