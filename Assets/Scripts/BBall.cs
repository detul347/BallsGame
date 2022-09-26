using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBall : Ball
{
    private void OnMouseDown()
    {
        var Sound = GameObject.Find("Sound").GetComponent<SoundAndEffects>();
        Sound.BadSoundPlay();
        _gameManager.Points--;
        Instantiate(HitImpact, transform.position,transform.rotation);
        HitImpact.transform.position = transform.position;
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gameObject);
    }
}

