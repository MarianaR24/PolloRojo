
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Slider volumeSlider;
    public Audio[] audios;
    public static AudioManager instance;

    float volumeValue;
    float lastVolumeValue;
    float volSaved;

    void Awake()
    {
        volSaved = PlayerPrefs.GetFloat("Volumen");

        foreach (Audio a in audios)
        {
            a.source = gameObject.AddComponent<AudioSource>();
            a.source.clip = a.audioFile;
            a.source.volume = a.volume;
            a.source.pitch = a.pitch;
            a.source.loop = a.loop;
        }
    }

    void Start()
    {
        volumeSlider.value = volSaved;
        volumeValue = volumeSlider.value;
        ChangeVolume();
        Play("Musica");
    }

    void Update()
    {
        volumeValue = volumeSlider.value;

        if(volumeValue != lastVolumeValue)
        {
            ChangeVolume();
            GuardarVol();
        }
        lastVolumeValue = volumeValue;
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeValue;
    }

    public void GuardarVol()
    {
        PlayerPrefs.SetFloat("Volumen", volumeSlider.value);
        PlayerPrefs.Save();
    }

    public void Play(string name)
    {
        Audio a = Array.Find(audios, audio => audio.name == name);

        if (a == null)
        {
            Debug.LogWarning("El nombre del Audio " + name + " no existe");
            return;
        }

        a.source.Play();
    }
}
