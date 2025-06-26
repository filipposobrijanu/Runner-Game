using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private AudioSource jumpsfx;
    [SerializeField] private AudioSource crouchsfx;

    public float jump;
    private Rigidbody2D rb;
    private bool isGrounded;
    private Animator anim;
    public GameManager gm;
    public TickManager tm;
    private float counter;
    public TextMeshProUGUI guide;

    void Awake()
    {

        counter = 0;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
    void Update()
    {

        anim.SetBool("Grounded", isGrounded);

        if (Input.GetButton("Jump") && isGrounded)
        {
            jumpsfx.Play();
            counter++;
            rb.velocity = new Vector2(0, jump);
            anim.SetTrigger("Jump");

        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && isGrounded)
        {
            crouchsfx.Play();
            counter++;
            anim.SetTrigger("Slide");
            

        }

        if (counter > 9)
        {
                guide.gameObject.SetActive(false);
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {

            isGrounded = true;

        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {

            isGrounded = false;

        }
    } 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            
            gm.RestartGame();

        }

        if (other.gameObject.CompareTag("Tick"))
        {
            //anim.SetTrigger("GoldTick");
            tm.Tick();

        }

    }

}
