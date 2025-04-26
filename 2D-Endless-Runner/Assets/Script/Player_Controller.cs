using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float moveSpeed;
    Input_Controller inputController;
    Rigidbody2D rb;
    Vector2 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inputController = GameObject.FindWithTag("GameController").GetComponent<Input_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        playerDirection = new Vector2(0, inputController.vertical).normalized;
       
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * moveSpeed);
    }

    
}
