using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody2D body;
    Vector2 mousePos;
    

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
        if (horizontalInput < -0.01f) // input ranges from -1 to 1, positive being right side
            transform.localScale = new Vector3(-5,5,5);//picture default move left(do nothing)
         else if (horizontalInput > 0.01f) 
            transform.localScale = new Vector3(5,5,5);

        
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("attack", Input.GetMouseButtonDown(0) ==true);

        //if(Input.GetMouseButtonDown(0) == false) anim.SetBool("attack", false);
        // Vector2 lookDir = mousePos - body.position;
        // float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 0f;
        // body.rotation = angle;

        // //Debug.Log(transform.position);

        // //*** -90<angle<90 means the mouse rest on the right of the player
        // if (angle > -90 && angle < 90) //shot front face front (normal)
        // {
        //     //Debug.Log("right");
        //     body.rotation = angle;
        // }else{ // shoot back face back
        //     //Debug.Log("left");
        //     transform.localScale = new Vector3(-5,-5,5);
        // }

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