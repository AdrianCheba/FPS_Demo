using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBarrelDisablPowerUP: MonoBehaviour, DestroyInterface
{
    [SerializeField]
    GameObject powerUP;

    private void Start()
    {
        powerUP = GameObject.Find("Fire PowerUP");
    }

    public void MakeEffect()
    {
       Destroy(powerUP);
    }
 }
