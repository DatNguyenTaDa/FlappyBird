using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static Sound instance;
    public AudioSource hit;
    public AudioSource wing;
    public AudioSource die;
    public AudioSource point;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    //private void Start()
    //{
    //    hit = GetComponent<AudioSource>();
    //    wing = GetComponent<AudioSource>();
    //    die = GetComponent<AudioSource>();
    //    point = GetComponent<AudioSource>();
    //}
    //public void Hit()
    //{
    //    audioSource.PlayOneShot(hit);
    //}
    public void Hit()
    {
        hit.Play();
    }
    public void Wing()
    {
        wing.Play();
    }
    public void Die()
    {
        die.Play();
    }
    public void Point()
    {
        point.Play();
    }
}
