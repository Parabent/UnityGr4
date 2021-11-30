using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    private float range;
    public float minDistance = 10f;
    public float maxDistance = 30f;
    public bool onMoveToPlayer = false;
    private Movement charMovement;
    private Transform target;
    public float speed = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onMoveToPlayer && target!=null)
        {
            range = Vector2.Distance(transform.position, target.position);

            if (range > minDistance && range < maxDistance)
            {
                //Debug.Log(range);
                Vector3 temp = new Vector3(target.position.x, transform.position.y);
                //Vector3 temp1 = new Vector3(transform.position.x, transform.position.y);
                transform.position = Vector2.MoveTowards(transform.position, temp, speed * Time.deltaTime); ;
            }
        }
    }
    private void Awake()
    {
        charMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
}
