using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource audioSource;
    public static Sound instance;
    public AudioClip hit;
    public AudioClip wing;
    public AudioClip die;
    public AudioClip point;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    //public void Hit()
    //{
    //    audioSource.PlayOneShot(hit);
    //}
    public void Hit()
    {
        audioSource.PlayOneShot(hit);
    }
    public void Wing()
    {
        audioSource.clip = wing;
        audioSource.Play();
    }
    public void Die()
    {
        audioSource.clip = die;
        audioSource.Play();
    }
    public void Point()
    {
        audioSource.clip = point;
        audioSource.Play();
    }
}
