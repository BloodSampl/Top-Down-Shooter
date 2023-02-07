using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed;
    PlayerMovement player;
    Rigidbody2D rb;
    Vector2 velocity;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovement>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
        if (rb != null)
        {
            var playerFacing = player.transform.up;
            velocity = playerFacing;
            rb.velocity = velocity;
        }              
    }
}
