using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;

    private int jumpCount = 0;          
    private int maxJumps = 3;

    public AudioSource audioSource;
    public AudioClip jump;
    //internal AudioClip coinSound;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = new Vector2(0, -50);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GameManager.Instance.isGameOver && !EventSystem.current.IsPointerOverGameObject())
        {
            if (jumpCount < maxJumps)   
            {
                animator.SetTrigger("Jump");
                rb.velocity = new Vector2(rb.velocity.x, 0);
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

                audioSource.PlayOneShot(jump);

                jumpCount++;

            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
            GameManager.Instance.GameOver();

            ScoreController.instance.GameOver();
            animator.speed = 0;
        }
    }
}
