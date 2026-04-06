using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int coinCount = 0;
    public TextMeshProUGUI coinText;

    public void CoinCollected() 
    {
        coinCount++;
        coinText.text = "Monedas: " + coinCount;
    }
    
}
