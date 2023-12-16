using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform killingCheck;
    [SerializeField] private LayerMask killingLayer;
    [SerializeField] private List<Transform> groundCheck1;


    private float speed = 8f;
    private float jumpingPower = 16f;

    private float PostionXBefore = 0;
    private float PostionXAfter = 1;

    private GameManager gameManager;


    void Start()
    {
        
    }

    void Update()
    {   

        gameManager = GameManager.Instance;



        if (IsGrounded() && Input.GetKey("space"))
        {
            Jump();
        }
        Movement();
    }
        // void OnCollisionEnter2D(Collision2D collision)
        // {
        //     Debug.Log("colision: " + collision.gameObject.tag);
        //     Debug.Log("befor: " + PostionXBefore);
        //     Debug.Log("after:" + PostionXAfter);

        //     if (collision.gameObject.tag == "Dead" && PostionXBefore == transform.position.x)
        //     {
        //         gameManager.RestartGame();
        //     }
        // }





    private void Movement()
    {
        PostionXBefore = transform.position.x;
        rb.velocity = new Vector2(speed, rb.velocity.y);
        PostionXAfter = transform.position.x;

    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
    }

    private bool IsGrounded()
{

    foreach (Transform groundCheck in groundCheck1)
    {
        bool centerCheck = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        bool bottomCheck = Physics2D.OverlapCircle(groundCheck.position - new Vector3(0f, 0.5f, 0f), 0.1f, groundLayer);
        if (centerCheck || bottomCheck)
        {
            return true;
        }

    }
    return false;
}

}
