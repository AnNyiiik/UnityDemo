using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody2D Player;

    public GameObject Coins;

    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        float move_X = Input.GetAxis("Horizontal");
        Player.MovePosition(Player.position + Vector2.right * move_X * speed * Time.deltaTime);

        if (Input.GetKey("up"))
        {
            Player.transform.SetParent(null);
            Player.AddForce(Vector2.up * 70);
        }

        if (Player.position.y <= -10)
        {
            SceneManager.LoadScene(1);
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cloud_2"))
        {
            Player.transform.SetParent(collision.transform);
        }
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        var trigger = collider.gameObject;
        if (trigger.CompareTag("Coin"))
        {
            Destroy(trigger);
            var parent = trigger.gameObject.transform.parent.gameObject;
            if (parent.Equals(Coins) && parent.transform.childCount == 1)
            {
                SceneManager.LoadScene(2);
            }
        }

        if (trigger.CompareTag("Ghost"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
