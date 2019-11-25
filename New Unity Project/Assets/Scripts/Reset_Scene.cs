using UnityEngine;
using UnityEngine.SceneManagement;



public class Reset_Scene : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("r"))

            SceneManager.LoadScene("SampleScene");
    }

}


