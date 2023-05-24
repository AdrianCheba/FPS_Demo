using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicBarrelDisablPowerUP: MonoBehaviour, DestroyInterface
{
    [SerializeField]
    GameObject powerUP;

    private void Start()
    {
        powerUP = GameObject.Find("Toxic PowerUP");
    }

    public void MakeEffect()
    {
        powerUP.SetActive(false);
    }
 }
