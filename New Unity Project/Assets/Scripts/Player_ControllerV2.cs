using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ControllerV2 : MonoBehaviour
{
    Rigidbody rb;
    
    Transform camara;

    Vector3 movement;


    public float speed = 1;

    public bool canInteract = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camara = FindObjectOfType<Camera>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(camara.position.x,transform.position.y,camara.position.z));
        movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        movement = camara.rotation * movement;
        movement.y = rb.velocity.y;
        rb.velocity = movement;

        if (Input.GetKeyDown(KeyCode.K)&&canInteract)
        {
            Debug.Log("interrected");
        }
    }
}
