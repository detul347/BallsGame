using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ball;
    // Start is called before the first frame update
    void Start()
    { 
        InvokeRepeating("Spawn",1,1);
    }

    void Spawn()
    {
        int Index = Random.Range(0, ball.Length);
        Instantiate(ball[Index], new Vector2(-8,0), transform.rotation); ;
    }
}
