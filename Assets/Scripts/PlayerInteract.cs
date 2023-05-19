using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;

    [SerializeField] private float distance = 3f;
    [SerializeField] private LayerMask mask;

    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;  

    }

 
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, distance, mask))
        {
            if (hit.collider.GetComponent<Interactable>())
            {
                Debug.Log(hit.collider.GetComponent<Interactable>().promptMessage);
            }
        }
    }
}
