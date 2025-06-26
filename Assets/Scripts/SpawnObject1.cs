using UnityEngine;

public class SpawnObject1 : MonoBehaviour
{

    private Rigidbody2D rb1;
    public float speed1;
    private GameManager gm1;
    private float timer1;

    void Start()
    {
        gm1 = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        rb1 = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        timer1 += Time.deltaTime;
        if (timer1 > 7.5)
        {

            Destroy(gameObject);

        }

        rb1.velocity = Vector2.left * speed1;

    }
}
