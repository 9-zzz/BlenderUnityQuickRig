using UnityEngine;
using System.Collections;

public class SimplePlayer: MonoBehaviour
{
    Rigidbody rb;

    public int health = 100;

    public float speed = 5.0f;
    public float jumpSpeed = 12.0f;

    void Awake()
    {
        //S = this;
        rb = GetComponent<Rigidbody>();
    }

    // Explains 'FixedUpdate' -> http://unity3d.com/learn/tutorials/topics/scripting/update-and-fixedupdate
    void FixedUpdate()
    {
        // Explains 'GetAxis' -> https://unity3d.com/learn/tutorials/topics/scripting/getaxis
        float xinput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(xinput * speed, rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }

}