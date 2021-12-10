using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Enemy enemy;
    private Transform target;
    public List<GameObject> firepoints;
    public bool isBoss = false;
    public float bulletForce = 10f;
    public float period = 0.0f;
    public bool onShooting = true;
    private float maxDistance = 25;
    private bool cooldown = false;
    private float range;
    private int i = 0;
    private int rand;
    public float cd = 1f;
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Update()
    {
        if(target!=null)
        {
            range = Vector2.Distance(transform.position, target.position);
        }
       
        if (onShooting && range < maxDistance)
        {
            if (period > 1.5f && ! isBoss)
            {
                Shoot();
                period = 0;     
            }
            if (isBoss && !cooldown)
            {
                //Debug.Log(firepoints.Count);
                if(firepoints.Count!=0)
                {
                    rand = Random.Range(0, firepoints.Count);
                    Debug.Log(rand);
                }
                
                ShootOther(rand);
                cooldown = true;
                StartCoroutine("wait");
            }
            period += UnityEngine.Time.deltaTime;
        }
    }

    void Shoot()
    {
        bulletPrefab.GetComponent<Bullet>().damage = enemy.damage;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, 5);
    }
    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    public IEnumerator wait()
    {
        yield return new WaitForSeconds(cd);
        cooldown = false;
    }
    public void ShootOther(int count)
    {
        if(firepoints.Count >0)
        {
            //Debug.Log("FIREPOINTSCOUNT"+firepoints.Count);
            try
            {
                firepoints[count].GetComponent<BossGun>().Shoot();
            }
            catch
            {

            }
        }

    }
    public void TakeFromList(int i)
    {
        if(firepoints.Count >1 && i<firepoints.Count)
        {
            firepoints.Remove(firepoints[i]);
        }
        else
        {
            firepoints.Remove(firepoints[firepoints.Count - 1]);
        }

    }
}
