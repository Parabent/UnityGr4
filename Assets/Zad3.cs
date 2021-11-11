using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad3 : MonoBehaviour
{
    public Vector3[] vectors;
    int counter = 0;
    private bool isPlayer;
    public GameObject player;
    public float speed = 0.001f;
    int direction = 1;
    private void Start()
    {
    }
    private void Update()
    {

        MoveTo();
    }

    void MoveTo()
    {
        if (counter <= vectors.Length - 1 && direction == 1)
        {
           
            if (transform.position != vectors[counter])
            {
                transform.position = Vector3.MoveTowards(transform.position, vectors[counter], speed * Time.deltaTime);
            }
            else
            {
                if (counter < vectors.Length - 1)
                {
                    counter++;
                    Debug.Log(counter);
                }
                else if(counter == vectors.Length - 1)
                {
                    direction = -1;
                }

            }
        }
        if (direction == -1)
        {
            Debug.Log(counter);
            if (transform.position != vectors[counter])
            {
                transform.position = Vector3.MoveTowards(transform.position, vectors[counter], speed * Time.deltaTime);
            }
            else
            {
                if (counter>0)
                {
                    counter--;
                }
                if(counter==0)
                {
                    direction = 1;
                }

            }
        }
    }
}
