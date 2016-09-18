using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SaveOnClick : MonoBehaviour
{
    public SaveData mushScore;
    public Death stuff;

	public void SaveScoreOnClick()
    {
        int temp = -1;
        int temp2 = -1;
        string ntemp = "";
        string ntemp2 = "";

        string PlayerName = stuff.playerInput.text.ToString();

        if (PlayerName != "")
        {
            for (int i = 0; i < 10; i++)
            {
                if (mushScore.localScore > PlayerPrefs.GetInt("Score" + i))
                {
                    temp = PlayerPrefs.GetInt("Score" + i);
                    ntemp = PlayerPrefs.GetString("Name" + i);

                    for (int j = 0 + i; j < 10; j++)
                    {
                        temp2 = PlayerPrefs.GetInt("Score" + (j + 1));
                        PlayerPrefs.SetInt("Score" + (j + 1), temp);
                        temp = temp2;

                        ntemp2 = PlayerPrefs.GetString("Name" + (j + 1));
                        PlayerPrefs.SetString("Name" + (j + 1), ntemp);
                        ntemp = ntemp2;
                    }
                    PlayerPrefs.SetInt("Score" + i, mushScore.localScore);
                    PlayerPrefs.SetString("Name" + i, stuff.playerInput.text);
                    break;
                }
            }
            SceneManager.LoadScene(2);
        }
    }
}
