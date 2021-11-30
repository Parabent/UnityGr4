using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text text;
    public int points =0;
    void Start()
    {
        text.text = "Points: " + Convert.ToString(this.points);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetPoints(int points)
    {
        this.points += points;

        text.text = "Points: " + Convert.ToString(this.points);
    }
}
