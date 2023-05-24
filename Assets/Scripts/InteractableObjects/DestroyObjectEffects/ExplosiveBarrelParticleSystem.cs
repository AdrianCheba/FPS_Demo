using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBarrelParticleSystem : MonoBehaviour, DestroyInterface
{
    [SerializeField]
    ParticleSystem particleSys;

    private void Start()
    {
        particleSys.Stop();
        particleSys.GetComponent<AudioSource>().Stop();
    }

    public void MakeEffect()
    {
        Invoke("StopEffect", 3f);
        particleSys.Play();
        particleSys.GetComponent<AudioSource>().Play();
    }

    void StopEffect()
    {
        particleSys = GameObject.FindGameObjectWithTag("ExplosiveBarrelEffect").GetComponent<ParticleSystem>();
        particleSys.Stop();
        particleSys.GetComponent<AudioSource>().Stop();
    }
 }
