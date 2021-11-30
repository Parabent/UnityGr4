using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColEn : MonoBehaviour
{
    private Character character;
    private int damage;
    void SetDamage(int damage)
    {
        this.damage = damage;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
        if (collision.gameObject.name == "Character")
        {
            collision.gameObject.SendMessage("TakeDamage", collision.otherCollider.gameObject.transform.GetComponent<Bullet>().damage);
        }

        Destroy(gameObject);
    }
}
