using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    private Vector2 mousePos;
    public float angle;
    public Rigidbody2D rb;
    Vector3 localScale;
    public bool player = false;
    void Start()
    {
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        }
        transform.localPosition = new Vector3(0, 0);

    }
    private void FixedUpdate()
    {
        if(player)
        {
            if (GetComponentInParent<Shooting>().firePointNumber == 1)
            {
                Vector2 lookDir = mousePos - rb.position;
                this.angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 88f;
                rb.rotation = angle;
            }
            else
            {
                Vector2 lookDir = mousePos - rb.position;
                this.angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 88f;
                rb.rotation = angle;
            }

        }

    }
}
