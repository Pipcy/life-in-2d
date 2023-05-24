using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody2D body;

    //for jump
    private bool grounded;
    private Animator anim;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2 (horizontalInput * speed, body.velocity.y);
        if (horizontalInput < 0f) // input ranges from -1 to 1, positive being right side
            transform.localScale = new Vector3(-5,5,5);//picture default move left(do nothing)
         else if (horizontalInput >= 0f) 
            transform.localScale = new Vector3(5,5,5);

        anim.SetBool("run", horizontalInput != 0);

        //jump
        if (Input.GetKey(KeyCode.Space) && (grounded)) {
            Jump(); }
        
    }

    //for jump//
    private void Jump() {
        body.velocity = new Vector2(body.velocity.x,speed);
        grounded = false; } 
    private void OnCollisionStay2D(Collision2D collision) { 
        float horizontalInput = Input.GetAxis("Horizontal");
        if (collision.gameObject.tag == "Ground") {
            grounded = true;}
        else if (collision.gameObject.tag == "Trap") {
            speed = 0;
            }
    }


}