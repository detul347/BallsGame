using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float force = 5;
    private float forceForRight = 3;
    private Rigidbody2D rb;
    private GameManager _gameManager;
    private SoundAndEffects _sound;
    void Start()
    {
        _sound = GameObject.Find("Sound").GetComponent<SoundAndEffects>();
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.down * force,ForceMode2D.Impulse);
        rb.AddForce(Vector2.right * forceForRight,ForceMode2D.Impulse);
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void OnMouseUp()
    {
        if (gameObject.CompareTag("GCircle"))
        {
            _gameManager.TextPoints.text = "Points: " + _gameManager.Points++;
            _sound.GoodSoundPlay();
            if (_gameManager.Points <= 0)
            {
                _gameManager.GameOver = true;
            }
        }

        if (gameObject.CompareTag("BBall"))
        {
            _gameManager.TextPoints.text = "Points: " + _gameManager.Points--;
            _sound.BadSoundPlay();
            if (_gameManager.Points <= 0)
            {
                _gameManager.GameOver = true;
            }
        }
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gameObject);
    }
}
