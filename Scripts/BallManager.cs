using UnityEngine;

public class BallManager : MonoBehaviour
{
    Rigidbody2D rb;
    int speed = 10;
    int score = 75;
    public GameObject WinPanel;
    bool lost;

    // Start is called before the first frame update
    void Start()
    {
        lost = false ;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.x - racketPos.x) / racketHeight;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "pad")
        {
            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;
            rb.velocity = dir * speed;
        }
        if(col.gameObject.tag == "Block")
        {
            Destroy(col.gameObject);
            score--;
        }
        if(col.gameObject.name == "Out")
        {
            lost = true;
        }
    }
    private void Update()
    {
        if(score <= 0 || lost)
        {
            Time.timeScale = 0;
            WinPanel.SetActive(true);
        }
    }
}
