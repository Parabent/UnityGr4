using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    private Character character;
    void OnCollisionEnter2D(Collision2D collision)
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
        if (collision.gameObject.name == "Character")
        {
            SceneManager.LoadScene("Win");
        }
    }
}

