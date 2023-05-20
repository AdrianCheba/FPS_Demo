using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Interactable
{
    [SerializeField] 
   // private GameObject cube;
    private bool up;

    public 

   
    void Start()
    {

    }

    protected override void Interact()
    {
        up = !up;
       // GetComponent<Animator>().SetBool("IsUP", up);
        currentHP -= 0.1f;

    }
}
