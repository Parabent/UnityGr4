using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    // ruch wok� osi Y b�dzie wykonywany na obiekcie gracza, wi�c
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;

    public float sensitivity = 200f;
    float yRotation = 0;
    float xRotation = 0;


    void Start()
    {
        // zablokowanie kursora na �rodku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy warto�ci dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        player.Rotate(Vector3.up * mouseXMove);
        float _mouseY = Input.GetAxis("Mouse Y");
        yRotation += mouseXMove;
        xRotation += _mouseY * sensitivity * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        transform.rotation = Quaternion.Euler(-xRotation, yRotation, 0);

    }

}
