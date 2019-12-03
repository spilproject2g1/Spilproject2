using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform[] camPos;
    public Transform startPos;
    public Transform targetPos;

    public float currentCamPos;
    public float moveSpeed;
    private float startTime;
    private float movelength;
    private float distCovered;

    public wall wall;
    // Start is called before the first frame update
    void Start()
    {
        movelength = Vector3.Distance(startPos.position, targetPos.position);
        startTime = Time.time;
        moveSpeed = 0.01f;
        transform.position = new Vector3(camPos[0].transform.position.x, camPos[0].transform.position.y, camPos[0].transform.position.z);
        transform.eulerAngles = new Vector3(35, 45, 0);
        currentCamPos = 1f;
        targetPos.position = transform.position;
        startPos.position = transform.position;
        wall = FindObjectOfType<wall>();
    }

    // Update is called once per frame
    void Update()
    {
        distCovered = (Time.time - startTime) * moveSpeed;
        startPos.position = transform.position;

        

        //change Camera Position
        if (Input.GetKey(KeyCode.E))
        {
            switch (currentCamPos)
            {
                case 1:
                    targetPos.position = camPos[1].position;
                    targetPos.rotation = camPos[1].rotation;
                    StartCoroutine("changePosTo2ndCO");
                    break;

                case 2:
                    targetPos.position = camPos[2].position;
                    targetPos.rotation = camPos[2].rotation;
                    StartCoroutine("changePosTo3rdCO");
                    break;

                case 3:
                    targetPos.position = camPos[3].position;
                    targetPos.rotation = camPos[3].rotation;
                    StartCoroutine("changePosTo4thCO");
                    break;

                case 4:
                    targetPos.position = camPos[0].position;
                    targetPos.rotation = camPos[0].rotation;
                    StartCoroutine("changePosTo1stCO");
                    break;

                default:
                    break;
            }
            wall.UpdateWalls();
        }

        if (Input.GetKey(KeyCode.Q))
        {
            switch (currentCamPos)
            {
                case 1:
                    targetPos.position = camPos[3].position;
                    targetPos.rotation = camPos[3].rotation;
                    StartCoroutine("changePosTo4thCO");
                    break;

                case 2:
                    targetPos.position = camPos[0].position;
                    targetPos.rotation = camPos[0].rotation;
                    StartCoroutine("changePosTo1stCO");
                    break;

                case 3:
                    targetPos.position = camPos[1].position;
                    targetPos.rotation = camPos[1].rotation;
                    StartCoroutine("changePosTo2ndCO");
                    break;

                case 4:
                    targetPos.position = camPos[2].position;
                    targetPos.rotation = camPos[2].rotation;
                    StartCoroutine("changePosTo3rdCO");
                    break;

                default:
                    break;
            }
            wall.UpdateWalls();
        }
    }
    IEnumerator changePosTo1stCO()
    {
        transform.position = Vector3.Lerp(startPos.position, targetPos.position, Time.time * moveSpeed);
        transform.rotation = Quaternion.Lerp(startPos.rotation, targetPos.rotation, Time.time * moveSpeed);
        yield return new WaitForSecondsRealtime(3f);
        currentCamPos = 1f;
        yield break;
    }

    IEnumerator changePosTo2ndCO()
    {
        transform.position = Vector3.Lerp(startPos.position, targetPos.position, Time.time * moveSpeed);
        transform.rotation = Quaternion.Lerp(startPos.rotation, targetPos.rotation, Time.time * moveSpeed);
        yield return new WaitForSecondsRealtime(Time.time * moveSpeed);
        currentCamPos = 2f;
        yield break;
    }

    IEnumerator changePosTo3rdCO()
    {
        transform.position = Vector3.Lerp(startPos.position, targetPos.position, Time.time * moveSpeed);
        transform.rotation = Quaternion.Lerp(startPos.rotation, targetPos.rotation, Time.time * moveSpeed);
        yield return new WaitForSecondsRealtime(Time.time * moveSpeed);
        currentCamPos = 3f;
        yield break;
    }

    IEnumerator changePosTo4thCO()
    {
        transform.position = Vector3.Lerp(startPos.position, targetPos.position, Time.time * moveSpeed);
        transform.rotation = Quaternion.Lerp(startPos.rotation, targetPos.rotation, Time.time * moveSpeed);
        yield return new WaitForSecondsRealtime(Time.time * moveSpeed);
        currentCamPos = 4f;
        yield break;
    }
}
