using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int player1Score = 0;
    private int player2Score = 0;
    public int scoreToReach;    
    
    [SerializeField]
    public TextMeshProUGUI player1ScoreText;

    [SerializeField]
    public TextMeshProUGUI player2ScoreText;

    public void Player1Goal()
    {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
        CheckIfGameOver();
    }

    public void Player2Goal()
    {
        player2Score++;
        player2ScoreText.text = player2Score.ToString();
        CheckIfGameOver();
    }

    private void CheckIfGameOver()
    {
        if (player1Score == scoreToReach || player2Score == scoreToReach)
        {
            SceneManager.LoadScene(1);
        }
    }
}
