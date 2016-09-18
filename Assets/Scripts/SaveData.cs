using UnityEngine;
using System.Collections;

public class SaveData : MonoBehaviour
{
    public int localScore = 0;

    public PlayerStats stats;    

    void Start()
    {

    }

    void Update()
    {
        localScore = stats.mushsCollected;
    }
}
