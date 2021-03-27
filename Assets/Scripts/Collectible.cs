using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collectible : MonoBehaviour
{
    public int score;
    public Text CoinText;

    private void Start()
    {
        score = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            score += 10;
            Destroy(other.gameObject);
        }
        else if (other.tag == "Respawn")
        {
            SceneManager.LoadScene("Level2");
        }
        else if (other.tag == "Finish")
        {
            SceneManager.LoadScene("Victory");
        }
    }

    private void Update()
    {
        CoinText.text = score.ToString();
    }
}
