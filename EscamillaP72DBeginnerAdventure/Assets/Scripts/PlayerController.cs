using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
   
    public InputAction MoveAction;
    public float speed = 3.0f;
    Rigidbody2D  rigidbody2d;
    Vector2 Move;
    
    public int maxHealth = 5;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {

        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);

    
        Vector2 position = (Vector2)rigidbody2d.position + move  * speed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

    void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);

    }

}