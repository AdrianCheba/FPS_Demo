using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardboardEffect : MonoBehaviour, DestroyInterface
{
    [SerializeField]
    Animator animator;
    int currentLayer;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void MakeEffect()
    {
        animator.SetBool("Sleep", true);
        currentLayer = gameObject.layer;
        gameObject.layer = 0;

        Invoke("WakeUpSamurai", 3);


    }

    void WakeUpSamurai()
    {
        animator.SetBool("Sleep", false);
        gameObject.GetComponent<CardboardEnemy>().currentHP = gameObject.GetComponent<CardboardEnemy>().maxHP;
        gameObject.layer = currentLayer;
    }
}
