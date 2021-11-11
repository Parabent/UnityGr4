using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadd2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 vec;
    private void Start()
    {
       
    }
    private void Update()
    {
        //if (transform.rotation.y <= 90)
        //{
        //    transform.Rotate(vec * Time.deltaTime);
        //}
        

     

    }
    public void Open()
    {
        transform.Rotate(vec);
    }
}
