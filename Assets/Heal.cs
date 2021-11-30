using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    // Start is called before the first frame update
    private Character character;
    public int health = 50;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
        try
        {
            if (collision.attachedRigidbody.name == "Character")
            {
                character.Heal(health);
                Destroy(gameObject);
            }
        }
        catch (Exception) { }
    }
}
