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
    }

    public void MakeEffect()
    {
        Invoke("StopEffect", 1);
        particleSys.Play();
    }

    void StopEffect()
    {
        particleSys = GameObject.FindGameObjectWithTag("ExplosiveBarrelEffect").GetComponent<ParticleSystem>();
        particleSys.Stop();
    }
 }
