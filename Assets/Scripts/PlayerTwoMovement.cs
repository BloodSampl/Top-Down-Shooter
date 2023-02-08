using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float bulletSpeed;
    [SerializeField] GameObject bulletPrefab;
    Rigidbody2D rb2;
    Vector2 velocity;

    private void Awake()
    {
        rb2 = GetComponentInChildren<Rigidbody2D>();
    }
    // Start is called before the first frame update
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
        velocity = new Vector2(Input.GetAxisRaw("Horizontal2"), Input.GetAxisRaw("Vertical2"));
        rb2.velocity = velocity * moveSpeed;
        if(rb2.velocity != Vector2.zero)
        {
            transform.up = velocity;
        }
    }
    void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject playerTwoBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            playerTwoBullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
        }
    }
}
