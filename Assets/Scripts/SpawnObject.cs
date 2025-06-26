using UnityEngine;

public class SpawnObject : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    private GameManager gm;
    private float timer;
    private Animator anim;
    private float score;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    void Update()
    {

        timer += Time.deltaTime;
        if (timer > 5)
        {

            Destroy(gameObject);

        }

        rb.velocity = Vector2.left * (speed + gm.speedMultiplier);


        score += Time.deltaTime * 10;

        if (score >= 1000)
        {

            anim.SetTrigger("ObjRainbow");


        }
    }
}
