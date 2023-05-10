using UnityEngine;
using UnityEngine.SceneManagement;

public class Ghost_Controller : MonoBehaviour
{
    private Transform Ghost;
    private float speed = 1.7f;
    private float range = 2f;
    private Vector2 direction = Vector2.up;
    private Vector2 startPosition;

    void Start()
    {
        Ghost = gameObject.GetComponent<Transform>();
        startPosition = Ghost.position;
    }
    void Update()
    {
        Ghost.Translate(direction * Time.deltaTime * speed);

        if (Ghost.position.y <= startPosition.y - range)
        {
            direction = Vector2.up;
        } else if (Ghost.position.y >= startPosition.y + range)
        {
            direction = Vector2.down;
        }
    }
}
