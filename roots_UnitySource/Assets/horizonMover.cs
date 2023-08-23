using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizonMover : MonoBehaviour
{

    public Rigidbody2D rb;
    public float runSpeed;
    public float repeatEachWhat;
    public bool able2move;
    public Transform rbt;
    public Vector2 originalLocation;
    public float stopwatch = 0.0f;



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
        stopwatch =  stopwatch + Time.deltaTime;
        if (stopwatch >= repeatEachWhat || able2move == false)
        {
            rbt.position = originalLocation;
            stopwatch = 0.0f;
        }

        if (able2move == true)
        {
            rb.velocity = new Vector2(runSpeed, rb.velocity.y);
        }
    }
}
