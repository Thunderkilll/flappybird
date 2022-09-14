using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 30f;
    public float jumpForce;
    public bool isDead = false;
    Animator animator;
    public GameObject gameOverUI;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        gameOverUI.SetActive(false);

        isDead = false;
        //Time.timeScale = 1;
    }
     
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isDead )
        {
            rb.AddForce(Vector2.up * jumpForce);
        }

   
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Obstacles")
        {
            //game Over logic
            Time.timeScale = 0;
            animator.SetBool("isDead",isDead);

            gameOverUI.SetActive(true);
        }
    }
}
