using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool canInteract = false;
    public bool isInteracting = false;
    private Player_ControllerV2 playerCtrl;
    public GameObject inspectCam;
    public GameObject interactableObject;
    // Start is called before the first frame update
    void Start()
    {
        inspectCam.gameObject.SetActive(false);
        playerCtrl = FindObjectOfType<Player_ControllerV2>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isInteracting == false)
        {
            if (transform.position.x - playerCtrl.transform.position.x < 2.5f && transform.position.z - playerCtrl.transform.position.z < 2.5f)
            {
                canInteract = true;
            }
            else
            {
                canInteract = false;
            }

        }

        if (canInteract == true)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                interact();
            }
        }
        if (isInteracting == true)
        {
            if(Input.GetKeyDown(KeyCode.C))
            {
                unInteract();
            }

        }
    }

    void interact()
    {
        isInteracting = true;
        inspectCam.gameObject.SetActive(true);
        interactableObject.gameObject.SetActive(true);
        canInteract = false;
        Debug.Log("interacting");

    }
    void unInteract()
    {
        inspectCam.gameObject.SetActive(false);
        interactableObject.gameObject.SetActive(false);
        isInteracting = false;
        Debug.Log("uninteracting");
    }
}
