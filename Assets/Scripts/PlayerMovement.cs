using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] float bulletSpeed = 20;
    [SerializeField] float boost;
    [SerializeField] string vertical;
    [SerializeField] string horizontal;
    [SerializeField] KeyCode shootKey;
    [SerializeField] AudioSource shootSound;
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
        if (Input.GetKey(KeyCode.V))
        {
            rb.velocity = velocity * boost;
        }
        else
        {
            velocity = new Vector2(Input.GetAxisRaw(horizontal), Input.GetAxisRaw(vertical));
            rb.velocity = velocity * speed;
            if(rb.velocity != Vector2.zero)
            {
                transform.up = velocity;
            }
        }
    }
    void Shoot()
    {
        if(Input.GetKeyDown(shootKey))
        {
            GameObject playerBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            playerBullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
            shootSound.Play();
        }
    }    
}
