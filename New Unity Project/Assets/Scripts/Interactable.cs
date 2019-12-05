using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool canInteract = false;
    public bool isInteracting = false;
    private Player_ControllerV2 playerCtrl;
    public GameObject inspectCam;
    // Start is called before the first frame update
    void Start()
    {
        inspectCam.gameObject.SetActive(false);
        playerCtrl = FindObjectOfType<Player_ControllerV2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x - playerCtrl.transform.position.x < 2.5f && transform.position.z - playerCtrl.transform.position.z < 2.5f)
        {
            canInteract = true;
        }
        else
        {
            canInteract = false;
        }

        if (canInteract == true)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                interact();
            }
        }
    }

    void interact()
    {
        isInteracting = true;
        inspectCam.gameObject.SetActive(true);

    }
}
