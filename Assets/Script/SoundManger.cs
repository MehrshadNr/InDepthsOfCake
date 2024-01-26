using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManger : MonoBehaviour
{
    public AudioSource MusicAudioSource;
    public AudioSource SoundEffectSource;
    public AudioClip Music;
    public AudioClip SoundEffect1;
    public AudioClip SoundEffect2;
    public AudioClip SoundEffect3;

    public void click()
    {
        SoundEffectSource.clip = SoundEffect1;
        SoundEffectSource.Play();
    }
    public void click1()
    {
        SoundEffectSource.clip = SoundEffect2;
        SoundEffectSource.Play();
    }
    public void click2()
    {
        SoundEffectSource.clip = SoundEffect3;
        SoundEffectSource.Play();
    }
}
