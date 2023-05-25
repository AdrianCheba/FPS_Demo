using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodCrateEffect : MonoBehaviour, DestroyInterface
{
    [SerializeField]
    GameObject openCrate;

    private void Start()
    {
        openCrate = GameObject.Find("AmmoCrateOpen");
        openCrate.SetActive(false);
    }

    public void MakeEffect()
    {
        gameObject.SetActive(false);
        openCrate.SetActive(true); 
    }
}
