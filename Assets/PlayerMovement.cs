using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    Rigidbody2D rb;
    [SerializeField] float speed;
    Vector2 velocity;
    private void Awake()
    {
        rb = GetComponentInChildren<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Shoot();
    }
    void Move()
    {
        velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = velocity * speed;
        transform.rotation = Quaternion.LookRotation(velocity);
    }
    void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject PlayerBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }    
}
