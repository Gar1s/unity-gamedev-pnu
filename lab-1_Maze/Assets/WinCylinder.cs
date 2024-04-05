using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Wincylinder : MonoBehaviour
{
    public Text winText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<FirstPersonMovement>().GetTotalCoins() == 6)
            {
                gameObject.SetActive(false);
                winText.text = "You win!";
                Invoke("ReloadScene", 2);
            }
            else
            {
                winText.text = "Not enougth coins to win!";
                StartCoroutine(ShowAndHideText());
            }
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator ShowAndHideText()
    {
        yield return new WaitForSeconds(2);
        winText.text = "";
    }

}
