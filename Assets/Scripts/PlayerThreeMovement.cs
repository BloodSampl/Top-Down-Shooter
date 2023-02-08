using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThreeMovement : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] float bulletSpeed = 20;
    [SerializeField] float boost = 20;
    Vector2 velocity;
    public string verticalAxis;
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
            velocity = new Vector2(Input.GetAxisRaw("Horizontal3"), Input.GetAxisRaw(verticalAxis))*boost;

        }
        else
        {
            velocity = new Vector2(Input.GetAxisRaw("Horizontal3"), Input.GetAxisRaw(verticalAxis));

        }
        rb.velocity = velocity * speed;
        if (rb.velocity != Vector2.zero)
        {
            transform.up = velocity;
        }
    }
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GameObject playerBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            playerBullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
        }
    }
}
