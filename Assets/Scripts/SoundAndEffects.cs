using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundAndEffects : MonoBehaviour
{
    protected private Ball _ball;
    protected private AudioSource Audio;
   public AudioClip BadSound;
    public AudioClip GoodSound;

    private void Start()
    {
        _ball = GetComponent<Ball>();
        Audio = GetComponent<AudioSource>();
     
    }
    public void BadSoundPlay()
    {
        Audio.PlayOneShot(BadSound);
  } 
    public void GoodSoundPlay()
    {
        Audio.PlayOneShot(GoodSound);
    }
    
}
