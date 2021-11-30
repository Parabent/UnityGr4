using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public Transform player;
    private Vector3 v3; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player!=null)
        {
            v3.x = player.position.x;
            v3.y = player.position.y + 1;
            v3.z = -10;
            transform.position = v3;
        }

    }
}
