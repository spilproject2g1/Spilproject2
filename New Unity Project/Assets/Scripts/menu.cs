using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject[] options;
    public GameObject[] other;
    public GameObject canvas;

    public bool InMainMenu = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !InMainMenu)
        {
            canvas.SetActive(!canvas.active);
            if (canvas.active)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }

    public void navigator(int _action)
    {
        switch (_action)
        {
            case 1:
                if (!InMainMenu)
                {
                    canvas.SetActive(!canvas.active);
                    Time.timeScale = 1;
                }
                else
                {
                    SceneManager.LoadScene(1);
                }
                break;
            case 2:
                for (int i = 0; i < options.Length; i++)
                {
                    options[i].SetActive(!options[i].active);
                }
                for (int i = 0; i < other.Length; i++)
                {
                    other[i].SetActive(!other[i].active);
                }
                break;
            case 3:
                Application.Quit();
                break;
            default:
                Debug.Log("that input is not set");
                break;
        }
    }
}
