using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("naura");
        if (other.gameObject.tag == "Player")
        {
            door.SendMessage("Open");
        }


    }
}
