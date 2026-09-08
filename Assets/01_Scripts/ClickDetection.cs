using UnityEngine;
using UnityEngine.InputSystem;

public class ClickDetection : MonoBehaviour
{
    // ---------- Start() -----------
    void Start()
    {
        
    }

    // ---------- Update() -----------
    void Update()
    {
        // new input system
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Vector3 mousePosition = Mouse.current.position.ReadValue();
            //print("Mouse has just been clicked: " + mousePosition); // 0,0 is the bottom left corner
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            //print("Mouse has just been clicked: " + mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector3.forward);
            if (hit.collider != null)
            {
                //print(hit.transform.gameObject.name);
                
                // Associative -- ClickDetection 'uses a' Enemy component
                if (hit.collider.TryGetComponent<Enemy>(out Enemy enemyComponent))
                {
                    enemyComponent.ChangeHealth(-1);
                }
            }
        }
    }
}// END class ClickDetection
