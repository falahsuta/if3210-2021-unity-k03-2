using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVol : MonoBehaviour
{
    public AudioMixer mixer;
    
    public void setLevel (float sliderVal)
    {
        mixer.SetFloat("MusicVolume", Mathf.Log10(sliderVal) * 20);
    }
}
