using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string weaponName;

    void Awake()
    {
        weaponName = gameObject.name;
    }
}
