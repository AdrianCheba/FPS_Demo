using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AmmoAndAspektsUI : MonoBehaviour
{

    int maxAmmo;
    int currentAmmo;
    [SerializeField]
    private TextMeshProUGUI ammoState;

    string aspekt1;
    string aspekt2;
    string powerUP;
    [SerializeField]
    Sprite[] aspectsImages;
    [SerializeField]
    Image aspektImage1;
    [SerializeField]
    Image aspektImage2;
    [SerializeField]
    Image powerUPImage;


    void Start()
    {
        maxAmmo = GetComponent<WeaponsData>().ammo;
        currentAmmo = maxAmmo;

    }

    void Update()
    {
        CheckAmmoState();
        CheckAspektsState();
    }

    void CheckAmmoState()
    {
        currentAmmo = GetComponent<WeaponsData>().ammo;
        ammoState.text = currentAmmo + "/" + maxAmmo;
    }

    void CheckAspektsState()
    {
        aspekt1 = GetComponent<WeaponsData>().aspect1;
        aspekt2 = GetComponent<WeaponsData>().aspect2;
        powerUP = GetComponent<WeaponsData>().powerUP;

        foreach (Sprite obj in aspectsImages)
        {
            if (aspekt1 == obj.name) aspektImage1.sprite = obj;

            if (aspekt2 == obj.name) aspektImage2.sprite = obj;

            if (powerUP == obj.name) 
            {
                powerUPImage.enabled = true;
                powerUPImage.sprite = obj;
            }
            else if(powerUP == "") powerUPImage.enabled= false;
        }


    }
}
