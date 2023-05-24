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

        yield return new WaitForSeconds(GetComponent<WeaponsData>().reloadTime - 0.25f);

        animator.GetComponent<Animator>().SetBool("IsReloading", false);

        yield return new WaitForSeconds(0.25f);

        GetComponent<WeaponsData>().ammo = maxAmmo;

        isReloading = false;
    }
}
