using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ControllerV2 : MonoBehaviour
{
    Rigidbody rb;
    Transform camara;
    Vector3 movement;

    Interactable interactScript;

    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        interactScript = FindObjectOfType<Interactable>();
        rb = GetComponent<Rigidbody>();
        camara = FindObjectOfType<Camera>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(interactScript.isInteracting == false)
        {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        movement = camara.rotation * movement;
        movement.y = rb.velocity.y;
        rb.velocity = movement;
        }


        if (Input.GetKeyDown(KeyCode.F))
        {
            //interract
        }
    }
}
