using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int coinCount = 0;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI resultText;
    public GameObject endUI;

    public void CoinCollected()
    {
        coinCount++;
        coinText.text = "Monedas: " + coinCount;
    }

    public void Win()
    {
        endUI.SetActive(true);
        resultText.text = "Success!";
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        endUI.SetActive(true);
        resultText.text = "Game Over :C";
        Time.timeScale = 0f;
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
    }

    public void VolverAlMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
