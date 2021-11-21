using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    public float jumpVelocity = 100f;

    public GameObject blood;

    private float moveInput;
    [SerializeField] private LayerMask platformsLayerMask;
    private Rigidbody2D rb;
    private BoxCollider2D boxCollider2d;

    private bool facingRight = true;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        boxCollider2d = GetComponent<BoxCollider2D>();
    }

    
    void FixedUpdate() {

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(facingRight == true && moveInput > 0) {
            Flip();
        }

        else if(facingRight == false && moveInput < 0) {
            Flip();
        }
        
    }

    void Update(){
        if(IsGrounded() && Input.GetKeyDown(KeyCode.W)) {

            rb.velocity = Vector2.up * jumpVelocity;

        }
    }

    private bool IsGrounded() {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, platformsLayerMask);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }


    void Flip() {

        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    
    }

    private void OnTriggerEnter2D(Collider2D other) { 

        if(other.gameObject.CompareTag("Coins")) {

            Instantiate (blood, transform.position, Quaternion.identity);
            Destroy(other.gameObject);

        }

    }


}




