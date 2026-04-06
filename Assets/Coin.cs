using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player") {
            FindObjectOfType<GameManager>().CoinCollected();
            Destroy(gameObject);
        }
    }
}
