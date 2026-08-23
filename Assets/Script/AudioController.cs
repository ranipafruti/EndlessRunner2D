using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip background;
    public AudioSource audioSource;
    public AudioClip jump;
    public AudioClip coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayJump()
    {
        audioSource.PlayOneShot(jump);
    }

    public void PlayCoin()
    {
        audioSource.PlayOneShot(coin);
    }
}
