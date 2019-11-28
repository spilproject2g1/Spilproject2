using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumenControler : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetVolumen(float sliderValue)
    {
        mixer.SetFloat("mucik", Mathf.Log10(sliderValue)*20);
    }
}
