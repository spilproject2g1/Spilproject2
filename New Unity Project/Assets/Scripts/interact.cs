using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public Player_ControllerV2 playerController;

    private void OnTriggerEnter(Collider other)
    {
        playerController.canInteract = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerController.canInteract = false;
    }
}
