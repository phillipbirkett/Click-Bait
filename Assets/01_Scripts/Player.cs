using System;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int health;
    private TMP_Text healthLabel; // Aggregation
    
    // ---------------- Start() --------------- is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthLabel = GetComponentInChildren<TMP_Text>();
        healthLabel.text = "" + health;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // print("hello");
       if (collision.transform.CompareTag("Enemy"))
       {
           health -= collision.gameObject.GetComponent<Enemy>().health; // Association
           healthLabel.text = "" + health;
           Destroy(collision.gameObject);
       }
    }
}
