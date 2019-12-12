using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    public GameObject interactableObject;
    Player_ControllerV2 playerCtrl;
    Interact_Manager interactManager;
    // Start is called before the first frame update
    void Start()
    {
        playerCtrl = FindObjectOfType<Player_ControllerV2>();
        interactManager = FindObjectOfType<Interact_Manager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
