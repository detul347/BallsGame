using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject[] ball;
    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (_gameManager.GameOver == false)
        {
            int Index = Random.Range(0, ball.Length);
            Instantiate(ball[Index], new Vector2(-8, 0), transform.rotation);
            yield return new WaitForSeconds(1);
        }
    }
}
