using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
public class GameManager : MonoBehaviour
{
    public PostProcessVolume _postProcessVolume;
    public TextMeshProUGUI TextPoints;
    public int Points;
    public bool GameOver;
    private Ball _ball;
    private GameObject Buttom;
    private GameObject resumeButton;
    private Bloom _bloom;
    void Start()
    {
        _postProcessVolume = GetComponent<PostProcessVolume>();
        _postProcessVolume.profile.TryGetSettings(out _bloom);
        Points = 0;
    }
    private void Update()
    {
        if (Points < 0)
        {
          GameOver = true;
        }
        TextPoints.text = "Points: " + Points;
    }

     public void Pause()
     {
         Buttom = GameObject.Find("Pause");
         Destroy(Buttom);
        Time.timeScale = 0;
        _bloom.intensity.value = 17.88f;
    }
     public void Resume()
     {
         _bloom.intensity.value = 0f;
         Time.timeScale = 1;
     }
}
