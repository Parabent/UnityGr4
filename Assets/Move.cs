using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody rb;
    public Vector3 vector;
    private Vector3 vec;
    private int Direction = -1;
    void Start()
    {
        vector.x = 0.4f;
        vector.y = 0;
        vector.z = 0;
        vec = rb.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch (Direction)
        {
            case -1:
                if (rb.position.x >= vec.x + 10)
                {
                    vector.x = -0.4f;
                }
                else
                {
                    Direction = 1;
                }
                break;

            case 1:
                if (rb.position.x <= vec.x)
                {
                    vector.x = 0.4f;
                }
                else
                {
                    Direction = -1;
                }
                break;
        }
        rb.MovePosition(rb.position + vector * moveSpeed * Time.fixedDeltaTime);
    }

}
