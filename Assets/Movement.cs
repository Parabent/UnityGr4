using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 movement;
    private Vector2 jumpVelocityToAdd;
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public float jumpSpeed = 1f;
    public float jumpHeight;
    public int isJumping = 0;
    float jumpForce;
    private GameObject firepoint;
    void Start()
    {
        jumpForce = Mathf.Sqrt(jumpHeight * -2 * (Physics2D.gravity.y * rb.gravityScale));
        firepoint = GameObject.FindGameObjectWithTag("FirePoint");
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        if(Input.GetKeyDown(KeyCode.A))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            firepoint.GetComponent<SpriteRenderer>().flipY = true;
            GetComponent<Shooting>().SetFirePoint(2);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            firepoint.GetComponent<SpriteRenderer>().flipY = false;
            GetComponent<Shooting>().SetFirePoint(1);
        }
        //movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && isJumping != 2)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isJumping++;
        }
    }

    private void FixedUpdate()
    {
       transform.position = (rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
    public void SpeedUp(int speed)
    {
        moveSpeed += speed;
        StartCoroutine("wait",speed);
    }
    public IEnumerator wait(int speed)
    {
        yield return new WaitForSeconds(5);
        moveSpeed -= speed;
    }
}
