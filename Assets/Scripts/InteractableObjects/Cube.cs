using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Interactable
{
    void Start()
    {

    }

    protected override void Interact()
    {
        maxHP = 120f;
        currentHP -= 15.1f;
        if(currentHP <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
