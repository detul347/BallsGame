using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ball : MonoBehaviour
{
    public ParticleSystem HitImpact;
    public float force = 5;
    public float forceForRight = 3;
    private Rigidbody2D rb; 
    public GameManager _gameManager;
    void Start()
    {
        var rb =  GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.down * force,ForceMode2D.Impulse);
        rb.AddForce(Vector2.right * forceForRight,ForceMode2D.Impulse);
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
}
