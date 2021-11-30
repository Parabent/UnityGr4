using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetJumping : MonoBehaviour
{
    public Movement movement;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherCollider.name == "BottomCollider")
        {
            movement.isJumping = 0;
        }
    }
}
