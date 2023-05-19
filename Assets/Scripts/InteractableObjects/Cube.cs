using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Interactable
{
    [SerializeField] 
    private GameObject cube;
   
    void Start()
    {
        
    }

    protected override void Interact()
    {
        Debug.Log("Interaction with" + gameObject.name);
    }
}
