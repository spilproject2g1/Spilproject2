using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Manager : MonoBehaviour
{
    public float currentInteractable;
    public bool canInteract = false;
    public bool isInteracting = false;
    private Player_ControllerV2 playerCtrl;
    public GameObject inspectCam;
    public GameObject[] interactable;
    public GameObject currentIntObject;
    public GameObject[] shownPicture;
    // Start is called before the first frame update
    void Start()
    {
        inspectCam.gameObject.SetActive(false);
        playerCtrl = FindObjectOfType<Player_ControllerV2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isInteracting == false)
        {
            if (interactable[0].transform.position.x - playerCtrl.transform.position.x < 2.5f &&
                interactable[0].transform.position.z - playerCtrl.transform.position.z < 2.5f)
            {
                currentInteractable = 0;
                canInteract = true;
            }
            else if(interactable[1].transform.position.x - playerCtrl.transform.position.x < 2.5f &&
                interactable[1].transform.position.z - playerCtrl.transform.position.z < 2.5f)
            {
                currentInteractable = 1;
                canInteract = true;
            }
            else if(interactable[2].transform.position.x - playerCtrl.transform.position.x < 2.5f &&
                interactable[2].transform.position.z - playerCtrl.transform.position.z < 2.5f)
            {
                currentInteractable = 2;
                canInteract = true;
            }
            else
            {
                currentInteractable = -1;
                canInteract = false;
            }
        }
        if (canInteract == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                switch (currentInteractable)
                {
                    case 0:
                        currentIntObject = shownPicture[0];
                        interact();
                        break;
                    case 1:
                        currentIntObject = shownPicture[1];
                        interact();
                        break;
                    case 2:
                        currentIntObject = shownPicture[2];
                        interact();
                        break;
                    default:
                        currentIntObject = null;
                        break;
                }
            }
        }
        if (isInteracting == true)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                unInteract();
            }

        }
    }

    void interact()
    {
        isInteracting = true;
        inspectCam.gameObject.SetActive(true);
        currentIntObject.SetActive(true);
        canInteract = false;
        Debug.Log("interacting");

    }
    void unInteract()
    {
        inspectCam.gameObject.SetActive(false);
        currentIntObject.SetActive(false);
        isInteracting = false;
        Debug.Log("uninteracting");
    }
}
