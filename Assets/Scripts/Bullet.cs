using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletLife = 3;
    [SerializeField] AudioSource explosionSound;


    private void Awake()
    {
        Destroy(gameObject, bulletLife);
        //explosionSound = FindObjectOfType<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
        //explosionSound.Play();
    }
}
