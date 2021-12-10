using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureCollision : MonoBehaviour
{
    private Character character;
    private Text text;
    public int points;
    private void Start()
    {
        text = GameObject.FindGameObjectWithTag("Points").GetComponent<Text>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
        try
        {
            if (collision.attachedRigidbody.name == "Character")
            {
                Stats.points += points;
                Debug.Log(Stats.points);
                text.GetComponent<Points>().SetPoints(points);
                Destroy(gameObject);
            }
        }
        catch (Exception) { }

    }
}
