using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;

    void Start()
    {
        
    }

    public void SetMusicVolume() 
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(Volume)
    }

    public void SetVolume(float volume) 
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SetMusicVolume();
    }
}
