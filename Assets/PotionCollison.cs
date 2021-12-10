using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionCollison : MonoBehaviour
{
    private Character character;
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
        try
        {
            if (collision.attachedRigidbody.name == "Character")
            {
                character.GetComponent<Movement>().SpeedUp(5);
                Destroy(gameObject);
            }
        }
        catch (Exception) { }

    }
}
