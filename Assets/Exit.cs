using UnityEngine;

public class Exit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            FindObjectOfType<GameManager>().Win();
        }
    }
}
