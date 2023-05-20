using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string promptMessage;
    public float maxHP = 1.0f;
    public float currentHP = 1.0f;

    public void BaseInteraction()
    {
        Interact();
    }

    protected virtual void Interact()
    {

    }


}
 