using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] AudioSource explosion;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] string playerHealth;
    [SerializeField] GameObject ui;

    private void Start()
    {
        text.text = playerHealth + health;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        text.text = playerHealth + health;
        if (health == 0)
        {
            Destroy(gameObject);
            explosion.Play();
            ui.gameObject.SetActive(true);
        }
    }
}
