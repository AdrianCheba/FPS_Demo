using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteWallEffect : MonoBehaviour, DestroyInterface
{
    public float radius = 5.0f;
    public float force = 700f;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void MakeEffect()
    {
     Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider nearbyObject in colliders)
        {
           Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }
    }
}
