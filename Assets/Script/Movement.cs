using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float leftLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance != null && GameManager.Instance.isGameOver)
            return;


        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);

        }
    }
}
