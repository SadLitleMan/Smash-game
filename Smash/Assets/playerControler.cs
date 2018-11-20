using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour {

    public float speed;
    public float jumpforce;
    private Rigidbody2D rb;
    private Vector2 input;
    public Animator animator;


    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        input = new Vector2(Input.GetAxisRaw("Horizontal")*speed, 0);
        animator.SetFloat("Speed",input.x);
    }

    void FixedUpdate()
    {
        rb.velocity = input;
    }
}


