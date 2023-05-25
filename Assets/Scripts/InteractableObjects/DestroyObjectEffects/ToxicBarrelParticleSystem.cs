using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicBarrelParticleSystem : MonoBehaviour, DestroyInterface
{
    [SerializeField]
    ParticleSystem explosion;
    [SerializeField]
    ParticleSystem leaq;
    bool isLeaking = false;


    private void Start()
    {
        explosion.Stop();
        explosion.GetComponent<AudioSource>().Stop();

        leaq.Stop();    
    }

    public void MakeEffect()
    {
        if (isLeaking == false)
        {
            leaq.Play();
            isLeaking = true;
            Invoke("StartEffect", 2f);
            Invoke("StopEffect", 5f);
        }
        
    }

    void StopEffect()
    {
        explosion = GameObject.FindGameObjectWithTag("ToxicBarrelEffect").GetComponent<ParticleSystem>();
        explosion.Stop();
        explosion.GetComponent<AudioSource>().Stop();
        
    }

    void StartEffect()
    {
       explosion.Play();
       explosion.GetComponent<AudioSource>().Play();
       gameObject.SetActive(false);

       leaq = GameObject.FindGameObjectWithTag("ToxicSprayEffect").GetComponent<ParticleSystem>();
       leaq.Stop();
    }
 }
