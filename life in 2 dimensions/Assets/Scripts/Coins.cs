using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coins : MonoBehaviour
{
    private int coinCount = 0;
    public TextMeshProUGUI coinCountText;
    //public GameObject[] coins;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++;
            coinCountText.text = "Coins: " + coinCount.ToString();
            other.gameObject.SetActive(false);
            // foreach (var coin in coins)
            // {
            //     if (coin == gameObject)
            //     {
            //         coin.SetActive(false);
            //         break;
            //     }
            // }
        }
    }
}
