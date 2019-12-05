using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private Player_ControllerV2 playerCtrl;
    public GameObject[] interactableObject;
    // Start is called before the first frame update
    void Start()
    {
        playerCtrl = FindObjectOfType<Player_ControllerV2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
