using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSwap : MonoBehaviour
{
    public GameObject[] weapons;
    public int currenWeapon = 0;
    private bool disableWeapons = true;

    [SerializeField]
    Image weaponImage;
    [SerializeField]
    Sprite[] weaponsImages;

    private void Awake()
    {
        weapons = GameObject.FindGameObjectsWithTag("Weapon");
        weapons[0].SetActive(true);
        weaponImage.sprite = weaponsImages[currenWeapon];
    }

    private void Update()
    {
        if (disableWeapons)
        {
            for (int i = 1; i < weapons.Length; i++)
            {
                weapons[i].SetActive(false);
            }
            disableWeapons= false;
        }
    }

    public void SwapWeapon()
    {
        if(currenWeapon == 0)
        {
            weapons[0].SetActive(true);
            weapons[weapons.Length - 1].SetActive(false);
            weaponImage.sprite = weaponsImages[currenWeapon];

            currenWeapon++;
        }
       else if(currenWeapon > 0)
        {
            weapons[currenWeapon - 1].SetActive(false);
            weapons[currenWeapon].SetActive(true);
            weaponImage.sprite = weaponsImages[currenWeapon];

            currenWeapon++;
        }

       
        if(currenWeapon >= weapons.Length) currenWeapon = 0;
    }
}
