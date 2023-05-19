using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Interactable
{
    [SerializeField] 
    private GameObject cube;
    private bool up;
   
    void Start()
    {
        
    }

    protected override void Interact()
    {
        up = !up;
        this.GetComponent<Animator>().SetBool("IsUP", up);
    }
}
