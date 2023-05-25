using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldPlayerMovement : MonoBehaviour
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
        float verticalInput = Input.GetAxis("Vertical");
        body.velocity = new Vector2 (horizontalInput * speed, verticalInput * speed);
        if (horizontalInput < 0f) // input ranges from -1 to 1, positive being right side
            transform.localScale = new Vector3(-5,5,5);//picture default move left(do nothing)
         else if (horizontalInput >= 0f) 
            transform.localScale = new Vector3(5,5,5);

        anim.SetBool("run", horizontalInput != 0);

        // //jump
        // if (Input.GetKey(KeyCode.Space) && (grounded)) {
        //     Jump(); }
        
    }

    // //for jump//
    // private void Jump() {
    //     body.velocity = new Vector2(body.velocity.x,speed);
    //     grounded = false; } 


}