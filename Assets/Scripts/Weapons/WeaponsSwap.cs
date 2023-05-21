using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsSwap : MonoBehaviour
{
    public GameObject[] weapons;
    public int currenWeapon = 0;

    private void Awake()
    {
        weapons = GameObject.FindGameObjectsWithTag("Weapon");
        weapons[1].SetActive(false);
        weapons[2].SetActive(false);

    }

    public void SwapWeapon()
    {
       switch (currenWeapon)
        {
            case 0:
                weapons[0].SetActive(true);
                weapons[2].SetActive(false);
                currenWeapon++;
                break;
            case 1:
                weapons[1].SetActive(true);
                weapons[0].SetActive(false);
                currenWeapon++;
                break;
            case 2:
                weapons[2].SetActive(true);
                weapons[1].SetActive(false);
                currenWeapon++;
                break;

        }
       
        if(currenWeapon >= weapons.Length) currenWeapon = 0;
    }
}
