using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadd2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 vec;
    public Vector3 left;
    public Vector3 right;
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
    public void Open(int version)
    {
        if(version == 1)
        {
            transform.Rotate(vec);
        }
        if(version == 2)
        {
            transform.position += left * Time.deltaTime;
        }
        if(version == 3)
        {
            transform.position += right * Time.deltaTime;
        }
      
    }
    //public void Open2()
    //{
    //    transform.position += left * Time.deltaTime;
    //}
    //public void Open3()
    //{
    //    transform.position += right * Time.deltaTime;
    //}
}
