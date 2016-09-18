using UnityEngine;
using System.Collections;

public class ResetData : MonoBehaviour
{

    public void ResetDataOnClick()
    {
        for (int i = 0; i < 10; i++)
        {
            PlayerPrefs.SetString("Name" + i, "NaN");
            PlayerPrefs.SetInt("Score" + i, 0);
        }      
    }
}
