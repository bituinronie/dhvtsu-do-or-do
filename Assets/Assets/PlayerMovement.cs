using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public float flapHeight;
    public GameObject pipe_up;
    public GameObject pipe_down;
    public TextMeshProUGUI scoreText;
    public float jumpAmount = 8f;

    void Start (){
        rb = GetComponent<Rigidbody2D>();

    }

    private int score;

   
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, flapHeight);
        }
        if (transform.position.y>18 || transform.position.y <-19)
        {
            Death();
        }
    }
    public void Death()
    {
        rb.velocity = Vector3.zero;
        transform.position = new Vector2(0, 0);
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if(collision.gameObject.CompareTag("ScoreTrigger"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
