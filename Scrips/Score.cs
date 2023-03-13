using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
    [SerializeField] private TMP_Text highScore;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        score.text ="Score: " + WallSpawn.GetScore().ToString();
        highScore.text = "Your High Score: " + WallSpawn.GetHighScore().ToString();
    }
}
