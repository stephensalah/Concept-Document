using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField]public float speed;
    
    private bool grounded;
    public bool move=true;
    private void Awake(){
        body = GetComponent<Rigidbody2D>();
    }


    private void Update(){
        if (move==true){
            body.velocity = new Vector2(Input.GetAxis("Horizontal")* speed,body.velocity.y);

            if (Input.GetKey(KeyCode.Space)&& grounded){
                Jump();
                
            }
        }
    }
    private void Jump(){
        body.velocity = new Vector2(body.velocity.x,speed);
        grounded=false;
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="Ground"){
            
            grounded=true;
        
        }
        
    }
}
