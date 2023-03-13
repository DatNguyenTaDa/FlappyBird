using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speedPullet;
    [SerializeField] private GameObject[] targets;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * speedPullet;
        if (transform.position.x > 3)
        {
            Debug.Log("ban ban");
            transform.gameObject.SetActive(false);
        }
        if (Mathf.Round(transform.position.x) == Mathf.Round(targets[Bird1.temp].transform.position.x))
        {
            if(transform.position.y <= targets[Bird1.temp].transform.position.y + 0.5f && transform.position.y >= targets[Bird1.temp].transform.position.y - 0.5f)
            {
                targets[Bird1.temp].SetActive(false);
            }
        }
    }
}
