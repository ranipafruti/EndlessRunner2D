using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinMovement : MonoBehaviour
{

    [SerializeField] private float speed;

    public AudioSource audioSource;
    public AudioClip coinSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        
        if(transform.position.x < -12)
        {
           
            Destroy(gameObject);    
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioSource.PlayOneShot(coinSound);
            ScoreController.instance.AddScore();
            
            Destroy(gameObject, 0.1f);
        }
    }
}
