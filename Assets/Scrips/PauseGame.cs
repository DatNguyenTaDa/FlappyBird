using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private Canvas pauseGame;
    // Start is called before the first frame update
    void Start()
    {
        pauseGame.gameObject.SetActive(false);        
    }

    // Update is called once per frame
    void Update()
    {
        if (FlappyBird.birdActive == FlappyBird.SetActive.Alive)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                pauseGame.gameObject.SetActive(true);
                //isHide = true;
                FlappyBird.birdActive = FlappyBird.SetActive.Dead;
            }
        }
        else
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                pauseGame.gameObject.SetActive(false);
                //isHide = true;
                FlappyBird.birdActive = FlappyBird.SetActive.Alive;
            }

        }
        
    }
    public void Pause()
    {
        pauseGame.gameObject.SetActive(true);
        FlappyBird.birdActive = FlappyBird.SetActive.Dead;
    }
    public void Remuse()
    {
        pauseGame.gameObject.SetActive(false);
        FlappyBird.birdActive = FlappyBird.SetActive.Alive;
    }
    public void GoHome()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
