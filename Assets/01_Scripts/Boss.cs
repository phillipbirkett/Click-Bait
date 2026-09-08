using UnityEngine;
using UnityEngine.UI;

// Inheritance -- Boss is an Enemy
public class Boss : Enemy
{
    public string message = "Hello World!";
    
    // Polymorphism -- Boss 'overrides' current default 
    public override void Move()
    {
        direction = transform.position - Vector3.zero;
        Vector3 rotateDirection = Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.forward) * direction;
        transform.position = rotateDirection;
    }
}
