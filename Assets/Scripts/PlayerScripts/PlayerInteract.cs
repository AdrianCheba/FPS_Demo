using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;

    [SerializeField] private float distance = 3f;
    [SerializeField] private LayerMask mask;

    private PlayerUI playerUI;
    private InputManager inputManager;

    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;  
        playerUI= GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
    }

 
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hit;
        playerUI.UpdateText(string.Empty);
        if(Physics.Raycast(ray, out hit, distance, mask))
        {
            if (hit.collider.GetComponent<Interactable>())
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                playerUI.UpdateText(hit.collider.GetComponent<Interactable>().promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteraction();
                }
            }
        }
    }
}
