using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI TextPoints;
    public int Points;
    // Start is called before the first frame update
    void Start()
    {
        Points = 0;
    }

    private void Update()
    {
        TextPoints.text = "Points: " + Points;
    }
}
