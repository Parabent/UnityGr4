using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody rb;
    public Vector3 vector;
    private Vector3 vec;
    private int Direction = -1;
    private Vector3 rot;
    private bool rotate;
    void Start()
    {
        vector.x = 0.0f;
        vector.y = 0.0f;
        vector.z = 0;
        vec = rb.position;
        rot.x = 0;
        rot.y = 0;
        rot.z = 90;
        rotate = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch (Direction)
        {
            case -1:
                if (rb.position.x <= vec.x + 10)
                {
                    if(rotate)
                    {
                        rb.transform.Rotate(rot);
                        rotate = false;
                    }
                    vector.y = 0;
                    vector.x = 0.4f;
                   
                }
                else
                {
                    rotate = true;
                    Direction = 1;
                }
                break;
            case 1:
                if (rb.position.y <= vec.y + 10 && rb.position.x >= vec.x + 10)
                {
                    if (rotate)
                    {
                        rb.transform.Rotate(rot);
                        rotate = false;
                    }
                    vector.x = 0;
                    vector.y = 0.4f;
                    
                }
                else
                {
                    rotate = true;
                    Direction = 2;
                }
                break;
            case 2:
                if (rb.position.y >= vec.y + 10 && rb.position.x >=vec.x)
                {
                    if (rotate)
                    {
                        rb.transform.Rotate(rot);
                        rotate = false;
                    }
                    vector.y = 0;
                    vector.x = -0.4f;
                }
                else
                {
                    rotate = true;
                    Direction = 3;
                }
                break;
            case 3:
                if(rb.position.x <= vec.x && rb.position.y >= vec.y )
                {
                    if (rotate)
                    {
                        rb.transform.Rotate(rot);
                        rotate = false;
                    }
                    vector.x = 0;
                    vector.y = -0.4f;
                    
                }
                else
                {
                    rotate = true;
                    Direction = -1;
                }
                break;
        }
        rb.MovePosition(rb.position + vector * moveSpeed * Time.fixedDeltaTime);
       
    }
}
