using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour {

    public float speed = 1f;
    private Rigidbody2D rb;

    
    
    void Start() {
        rb = this.GetComponent<Rigidbody2D>();
        

        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, -speed);

    }
}
