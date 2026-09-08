using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Inheritance -- Boss is an Enemy
public class Boss : Enemy
{
    public string message = "Hello World!";
    public UnityEvent onGameWin;

    protected override void Start()
    {
        base.Start();
        healthLabel.text = message;
    }
    
    // Polymorphism -- Boss 'overrides' current default behaviour of 'Move()'
    public override void Move()
    {
        direction = transform.position - Vector3.zero;
        Vector3 rotateDirection = Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.forward) * direction;
        transform.position = rotateDirection;
    }

    public void SayMessage(string newMessage)
    {
        healthLabel.text = newMessage;
    }

    public override void ChangeHealth(int amount)
    {
        health += amount;
        healthLabel.text = "" + health;
        if(health <= 0) onGameWin.Invoke();
    }
}
