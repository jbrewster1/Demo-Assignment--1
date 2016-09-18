using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreToText : MonoBehaviour
{
    public LoadData scores;
    public Text Score0;
    public Text Score1;
    public Text Score2;
    public Text Score3;
    public Text Score4;
    public Text Score5;
    public Text Score6;
    public Text Score7;
    public Text Score8;
    public Text Score9;

    public Text Name0;
    public Text Name1;
    public Text Name2;
    public Text Name3;
    public Text Name4;
    public Text Name5;
    public Text Name6;
    public Text Name7;
    public Text Name8;
    public Text Name9;

    void Update()
    {
        Score0.text = scores.score0.ToString() + " mushrooms";
        Score1.text = scores.score1.ToString() + " mushrooms";
        Score2.text = scores.score2.ToString() + " mushrooms";
        Score3.text = scores.score3.ToString() + " mushrooms";
        Score4.text = scores.score4.ToString() + " mushrooms";
        Score5.text = scores.score5.ToString() + " mushrooms";
        Score6.text = scores.score6.ToString() + " mushrooms";
        Score7.text = scores.score7.ToString() + " mushrooms";
        Score8.text = scores.score8.ToString() + " mushrooms";
        Score9.text = scores.score9.ToString() + " mushrooms";

        Name0.text = scores.name0.ToString();
        Name1.text = scores.name1.ToString();
        Name2.text = scores.name2.ToString();
        Name3.text = scores.name3.ToString();
        Name4.text = scores.name4.ToString();
        Name5.text = scores.name5.ToString();
        Name6.text = scores.name6.ToString();
        Name7.text = scores.name7.ToString();
        Name8.text = scores.name8.ToString();
        Name9.text = scores.name9.ToString();
    }
}
