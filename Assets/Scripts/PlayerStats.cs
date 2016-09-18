using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{
    private GameObject HUDCamera;
    private GameObject HUDSprite;

    public int health = 1;
    public int mushsCollected = 0;

    void Start()
    {
        HUDCamera = GameObject.FindGameObjectWithTag("HUD_Camera");
        HUDSprite = GameObject.FindGameObjectWithTag("HUD_Sprite");
    }

	public void CollectMush(int mushValue)
    {
        this.mushsCollected = this.mushsCollected + mushValue;
        this.HUDSprite.GetComponent<mushCounter>().value = this.mushsCollected;
    }
}
