using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runAnimator : MonoBehaviour
{

    public Rigidbody2D rb;
    public float runSpeed;
    public bool able2move;
    public Transform rbt;
    public Vector2 originalLocation;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rbt = gameObject.GetComponent<Transform>();
        originalLocation = new Vector2(rbt.position.x, rbt.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (able2move == true)
        {
            rb.velocity = new Vector2(runSpeed, rb.velocity.y);
        }
        else 
        {
            rbt.position = originalLocation;
        }
    }
}
