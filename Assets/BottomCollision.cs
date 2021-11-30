using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomCollision : MonoBehaviour
{
    private Character character;
    void OnCollisionEnter2D(Collision2D collision)
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
        if (collision.gameObject.name == "Character")
        {
            character.Die();
        }
        if(collision.gameObject.name.Contains("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().Die();
        }
    }
}
