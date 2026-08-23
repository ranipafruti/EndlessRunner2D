using UnityEngine;

public class PlatformScroller : MonoBehaviour
{
    [SerializeField] private float speed;         
    public Transform secondPlatform;  

    private float width;

    void Start()
    {
       
        width = GetComponent<SpriteRenderer>().size.x;
    }

    void Update()
    {
        if (GameManager.Instance.isGameOver) return;

        transform.Translate(Vector3.left * speed * Time.deltaTime);
        secondPlatform.Translate(Vector3.left * speed * Time.deltaTime);

      
        if (transform.position.x <= -width)
        {
            transform.position = new Vector3(secondPlatform.position.x + width, transform.position.y, transform.position.z);
        }

        if (secondPlatform.position.x <= -width)
        {
            secondPlatform.position = new Vector3(transform.position.x + width, secondPlatform.position.y, secondPlatform.position.z);
        }
    }
}
