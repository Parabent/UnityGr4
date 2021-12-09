using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool onMovement;
    private int Direction = 1;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float minX;
    public float maxX;
    public float moveSpeed;
    private Vector3 vec;
    private Vector2 temp;
    private Transform target;
    private float range;
    public float distanceToPlayer;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(target.position.x >= minX && target.position.x <= maxX)
        {
            onMovement = false;
        }
        else
        {
            onMovement = true;
        }
        if (onMovement)
        {
            switch (Direction)
            {
                case -1:

                    if (rb.position.x >= minX)
                    {
                        vec = new Vector3(-1, 1, 1);
                        gameObject.transform.localScale = vec;
                        movement.x = -1.0f;
                    }
                    else
                    {
                        Direction = 1;
                        vec = new Vector3(1, 1,1);
                        gameObject.transform.localScale = vec;
                    }
                    break;

                case 1:

                    if (rb.position.x <= maxX)
                    {
                        movement.x = 1f;
                        vec = new Vector3(1, 1, 1);
                        gameObject.transform.localScale = vec;
                    }
                    else
                    {
                        Direction = -1;
                        vec = new Vector3(-1, 1,1);
                        gameObject.transform.localScale = vec;
                    }
                    break;
            }
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        else
        {
            if (target.position.x <= transform.position.x)
            {
                vec = new Vector3(-1, 1, 1);
                gameObject.transform.localScale = vec;
            }
            else
            {
                vec = new Vector3(1, 1, 1);
                gameObject.transform.localScale = vec;

            }
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }


    }
}
