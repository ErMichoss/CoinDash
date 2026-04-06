using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int coinCount = 0;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI resultText;

    public void CoinCollected() 
    {
        coinCount++;
        coinText.text = "Monedas: " + coinCount;
    }

    public void Win()
    { 
        resultText.text = "Success!";
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        resultText.text = "Game Over :C";
        Time.timeScale = 0f;
    }
}
