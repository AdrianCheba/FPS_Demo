using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShoot : MonoBehaviour
{
    public ParticleSystem shootFlash;
    public GameObject impactEffect;
    [SerializeField]
    private GameObject player;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    public void Shoot()
    {
        shootFlash.Play();
        shootFlash.GetComponent<AudioSource>().Play();
        Instantiate(impactEffect, player.GetComponent<PlayerInteract>().hit.point, Quaternion.LookRotation(player.GetComponent<PlayerInteract>().hit.normal));
    }
}
