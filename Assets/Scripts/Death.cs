using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;


public class Death : MonoBehaviour
{
    public GameObject Player;
    public Text textComponent;
    public InputField playerInput;
    public Button saveButton;
    public SaveData mushs;

    void Start()
    {
        textComponent.enabled = false;
        playerInput.enabled = false;
        playerInput.GetComponentInChildren<Text>().enabled = false;
        playerInput.GetComponent<Image>().enabled = false;
        saveButton.enabled = false;
        saveButton.GetComponentInChildren<Text>().enabled = false;
        saveButton.GetComponent<Image>().enabled = false;
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        int highScoreMet = 0;

        if(collider.tag == "Player")
        {
            DestroyObject(Player);
            

            int localScore = mushs.localScore;

            for (int i = 0; i < 10; i++)
            {
                if (localScore > PlayerPrefs.GetInt("Score" + i))
                {
                    textComponent.enabled = true;
                    playerInput.enabled = true;
                    playerInput.GetComponentInChildren<Text>().enabled = true;
                    playerInput.GetComponent<Image>().enabled = true;
                    saveButton.enabled = true;
                    saveButton.GetComponentInChildren<Text>().enabled = true;
                    saveButton.GetComponent<Image>().enabled = true;

                    highScoreMet = 1;
                    break;
                }
            }

            if(highScoreMet == 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
