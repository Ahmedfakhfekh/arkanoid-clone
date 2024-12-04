using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 10f;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();    
    }
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * speed;
        rb.velocity = new Vector2(x, 0f);
    }
}
