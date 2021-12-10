using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{

    public float cd;
    private bool cooldown;
    public GameObject gameobject;
    // Update is called once per frame
    void Update()
    {
        if(!cooldown)
        {
            gameobject.SetActive(false);
            StartCoroutine("wait");
            cooldown = true;
        }
    }
    public IEnumerator wait()
    {
        yield return new WaitForSeconds(cd);
        gameobject.SetActive(true);
        StartCoroutine("wait2");
        
       
    }
    public IEnumerator wait2()
    {
        yield return new WaitForSeconds(cd);
        cooldown = false;
    }

}
