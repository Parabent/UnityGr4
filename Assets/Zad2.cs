using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad2 : MonoBehaviour
{
    // Start is called before the first frame update
    private Quaternion vec;
    private void Update()
    {
        if(transform.rotation.y <90)
        {
            Debug.Log(vec);
            vec.y += 10f * Time.deltaTime;
            transform.rotation = vec;
        }
        
    }
    //public void Open()
    //{
    //    transform.rotation.y += 10f * Time.deltaTime;
    //}
}
