using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
   // public GameObject hitEffect;
    private Character character;
    private Enemy enemy;
    void OnCollisionEnter2D(Collision2D collision)
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
        if (collision.gameObject.name.Contains("Enemy") || collision.gameObject.tag == "Enemy")
        {
            Enemy other = collision.gameObject.GetComponent<Enemy>();
            if (other)
            {
                //other.gameObject.SendMessage("TakeDamage", character.damage);
                other.gameObject.GetComponent<Enemy>().TakeDamage(character.damage);
            }
        }
        Destroy(gameObject);
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 2f);
    }
}

