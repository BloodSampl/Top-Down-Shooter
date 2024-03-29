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
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
