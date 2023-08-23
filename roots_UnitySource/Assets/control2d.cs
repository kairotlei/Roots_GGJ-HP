using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control2d : MonoBehaviour
{
    public Rigidbody2D rb;
    public float RunSpeed;
    private float Horizontal;
    public bool CanJump;
    public bool CanShoot;
    public float JumpForce;
    private bool toJump;
    private bool toShoot;
    public ProjectileBehaviour ProjectPrefabNormal;
    public ProjectileBehaviour ProjectPrefabFlipped;
    
    public Transform ProjectSpawn;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();;
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        toJump = Input.GetKeyDown(KeyCode.Space);
        toShoot = Input.GetKeyDown(KeyCode.Return);
        rb.velocity = new Vector2(Horizontal * RunSpeed, rb.velocity.y);

        // JUMP PART
        if (CanJump == true && toJump == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            CanJump = false;
        }

        // FLIP TEX TO DIRECTION
        if (rb.velocity.x > 0.01f)
            spriteRenderer.flipX = false;
        else if (rb.velocity.x < -0.01f)
            spriteRenderer.flipX = true;

        // SHOOTING PART
        if (toShoot == true && CanShoot == true)
        {

            if (spriteRenderer.flipX == false)
                Instantiate(ProjectPrefabNormal, ProjectSpawn.position, transform.rotation);
            else if (spriteRenderer.flipX == true)
                Instantiate(ProjectPrefabFlipped, ProjectSpawn.position, transform.rotation);
        }

    }

    void FixedUpdate()
    {
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        CanJump = false;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        CanJump = true;
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        CanJump = true;
    }


}
