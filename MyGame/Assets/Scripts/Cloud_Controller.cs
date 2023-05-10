using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cloud_Controller : MonoBehaviour
{
    private Transform Cloud;
    private float speed = 1f;
    private float range = 4f;
    private Vector2 direction = Vector2.right;
    private Vector2 startPosition;

    void Start()
    {
        Cloud = gameObject.GetComponent<Transform>();
        startPosition = Cloud.position;
    }
    void Update()
    {
        Cloud.Translate(direction * Time.deltaTime * speed);

        if (Cloud.position.x <= startPosition.x - range)
        {
            direction = Vector2.right;
        } else if (Cloud.position.x >= startPosition.x + range)
        {
            direction = Vector2.left;
        }
    }
}
