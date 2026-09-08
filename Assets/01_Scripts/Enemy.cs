using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Enemy : MonoBehaviour
{
    // Attributes -- things that are unique about me!
    public float speed;
    public int health;
    protected Vector3 direction;
    protected TMP_Text healthLabel;
    
    // ---------- Start() -----------
    protected virtual void Start()
    {
        // B - A, Enemy - Player, so that the enemy is facing the player
        // Player sitting in the centre, which is Vector3(0,0,0)
        direction = Vector3.zero - transform.position;
        healthLabel = GetComponentInChildren<TMP_Text>();
        //healthLabel.text = health.ToString();
        healthLabel.text = "" + health;
        
    }

    // ----------- Update() -------------
    void Update()
    {
        Move();
        //transform.position += direction.normalized * speed * Time.deltaTime;
    }
    
    // 'virtual' gives permission to inherited objects to override this function
    public virtual void Move()
    {
        transform.position += direction.normalized * speed * Time.deltaTime;
    }
    
    public virtual void ChangeHealth(int amount)
    {
        health += amount;
        healthLabel.text = "" + health;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
