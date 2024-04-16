using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishGround : MonoBehaviour
{
    public Text winText;

    void Start()
    {
        winText.text = "";
    }

    void OnCollisionEnter(Collision other)
    {
        winText.text = "You win!";
        Invoke("ReloadScene", 2);
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("Player"))
    //     {
    //         winText.text = "You win!";
    //         Invoke("ReloadScene", 2);
    //     }
    // }

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
