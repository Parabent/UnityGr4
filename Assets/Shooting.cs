using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public Transform firePoint2;
    public int firePointNumber = 1;
    public GameObject bulletPrefab;
    public float bulletForce = 5f;
    private bool cooldown;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !cooldown)
        {
            Shoot();
            cooldown = true;
            StartCoroutine("wait");
        }


    }
    void Shoot()
    {
        if(firePointNumber == 1)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            Destroy(bullet, 5);
        }
        else
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint2.up * bulletForce, ForceMode2D.Impulse);
            Destroy(bullet, 5);
        }
    }
    public void SetFirePoint(int i)
    {
        firePointNumber = i;
    }
    public IEnumerator wait()
    {
        // animator.SetBool("isShooting", false);
        yield return new WaitForSeconds(1f);
        cooldown = false;
    }
}
