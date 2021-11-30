using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public float maxHealth = 100f;
    public float health;
    public int damage;
    public GameObject text;
    void Start()
    {
        health = maxHealth;
        text.GetComponent<SetHealth>().SetText(Convert.ToString(health));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        if(health>0)
        {
            health -= damage;
            text.GetComponent<SetHealth>().SetText(Convert.ToString(health));
        }
        if(health<=0)
        {
            Die();
        }
    }
    public void Heal(int health)
    {
        if(this.health + health <= maxHealth)
        {
            this.health += health;
        }
        else
        {
            this.health = maxHealth;
        }
        text.GetComponent<SetHealth>().SetText(Convert.ToString(this.health));

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
        }
    }
    public void Die()
    {
        SceneManager.LoadScene("GameOver");
        Destroy(gameObject,1f);
        
    }
}
