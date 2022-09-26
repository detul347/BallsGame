using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GBall : Ball
{
    private void OnMouseDown()
    {
        _gameManager.Points++;
        var Sound = GameObject.Find("Sound").GetComponent<SoundAndEffects>();
        Sound.GoodSoundPlay();
        Destroy(gameObject);
        Instantiate(HitImpact, transform.position,transform.rotation);
        HitImpact.transform.position = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        _gameManager.Points--;
        Destroy(gameObject);
    }
}
