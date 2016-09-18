using UnityEngine;
using System.Collections;

public class LoadData : MonoBehaviour
{
    public int score0;
    public int score1;
    public int score2;
    public int score3;
    public int score4;
    public int score5;
    public int score6;
    public int score7;
    public int score8;
    public int score9;

    public string name0;
    public string name1;
    public string name2;
    public string name3;
    public string name4;
    public string name5;
    public string name6;
    public string name7;
    public string name8;
    public string name9;

    void Start ()
    {
        score0 = PlayerPrefs.GetInt("Score" + 0);
        score1 = PlayerPrefs.GetInt("Score" + 1);
        score2 = PlayerPrefs.GetInt("Score" + 2);
        score3 = PlayerPrefs.GetInt("Score" + 3);
        score4 = PlayerPrefs.GetInt("Score" + 4);
        score5 = PlayerPrefs.GetInt("Score" + 5);
        score6 = PlayerPrefs.GetInt("Score" + 6);
        score7 = PlayerPrefs.GetInt("Score" + 7);
        score8 = PlayerPrefs.GetInt("Score" + 8);
        score9 = PlayerPrefs.GetInt("Score" + 9);

        name0 = PlayerPrefs.GetString("Name" + 0);
        name1 = PlayerPrefs.GetString("Name" + 1);
        name2 = PlayerPrefs.GetString("Name" + 2);
        name3 = PlayerPrefs.GetString("Name" + 3);
        name4 = PlayerPrefs.GetString("Name" + 4);
        name5 = PlayerPrefs.GetString("Name" + 5);
        name6 = PlayerPrefs.GetString("Name" + 6);
        name7 = PlayerPrefs.GetString("Name" + 7);
        name8 = PlayerPrefs.GetString("Name" + 8);
        name9 = PlayerPrefs.GetString("Name" + 9);

    }
}
