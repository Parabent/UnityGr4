using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 movement;
    private float moveSpeed = 2f;
    public GameObject player;
    private bool isPlayer;
    public Vector3 vec;
    private Vector3 startPos;
    int Direction = 1;
    private void Start()
    {
        startPos = transform.position;
        Debug.Log(startPos);
    }
    private void Update()
    {
        transform.position += movement * Time.deltaTime;
        if(isPlayer)
        {
            player.SendMessage("Stay", transform.position);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        PlatformMove();
        isPlayer = true;  
    }
    public void PlatformMove()
    {
        switch(Direction)
        {
            case 1:
                if (transform.position.x <vec.x)
                {
                    movement.x = 1f;
                }
                else
                {
                    Direction = -1;
                }
                break;

            case -1:
                if(transform.position.x > startPos.x)
                {
                    Debug.Log("123");
                    movement.x = -1f;
                }
                else
                {
                    Direction = 1;
                }
                break;
        }    

    }
}
