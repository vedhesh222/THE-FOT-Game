using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public int health;
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Bound For The Player

        if (transform.position.x < -3.30f)
        {
            transform.position = new Vector2(3.21f, transform.position.y);
        }

        if (transform.position.x > 3.21F)
        {
            transform.position = new Vector2(-3.30f, transform.position.y);
        }

        // Player Horizontal Movement

        float Horizontal = Input.GetAxis("Horizontal");


        Vector2 position = transform.position;

        position.x += Horizontal * playerSpeed * Time.deltaTime;


        transform.position = position;
        
    }
}
