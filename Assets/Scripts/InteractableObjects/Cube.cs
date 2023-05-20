using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Interactable
{
   

    public 

   
    void Start()
    {

    }

    protected override void Interact()
    {
        maxHP = 1.2f;
        currentHP -= 0.151f;
    }
}
