using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float maxHealth = 100;
    public float health;
    private Character character;
    public int damage;
    private Text text;
    public int points;
    public bool bossGun = false;
    public int number;
    void Start()
    {
        text = GameObject.FindGameObjectWithTag("Points").GetComponent<Text>();
        health = maxHealth;
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();

        }
    }
    public void Die()
    {
        if(bossGun)
        {
            gameObject.GetComponentInParent<Boss>().TakeDamage();
            gameObject.GetComponentInParent<EnemyShooting>().TakeFromList(number);
        }
        text.GetComponent<Points>().SetPoints(points);
        Destroy(gameObject, 0.01f);
    }
}
