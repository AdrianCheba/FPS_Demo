using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponReload : MonoBehaviour
{
    [SerializeField]
    int maxAmmo;
    [SerializeField]
    int currentAmmo;
    public bool isReloading = false;

    public GameObject animator;

    void Start()
    {
        maxAmmo = GetComponent<WeaponsData>().ammo;
        currentAmmo = maxAmmo;

    }

    private void OnEnable()
    {
        isReloading = false;
        animator.GetComponent<Animator>().SetBool("IsReloading", false);
    }

    // Update is called once per frame
    void Update()
    {
        currentAmmo = GetComponent<WeaponsData>().ammo;

        if (currentAmmo <= 0)
        {
           StartCoroutine(Reload());
            return;
        }
    }

    IEnumerator Reload()
    {
        isReloading = true;
             
        animator.GetComponent<Animator>().SetBool("IsReloading", true);

        animator.GetComponent<AudioSource>().Play();

        GetComponent<WeaponsData>().ammo = maxAmmo;

        yield return new WaitForSeconds(GetComponent<WeaponsData>().reloadTime);

        animator.GetComponent<Animator>().SetBool("IsReloading", false);

        isReloading = false;
    }
}
