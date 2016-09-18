using UnityEngine;
using System.Collections;

public class mushroomPickup : MonoBehaviour {

    public int mushValue = 1;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            PlayerStats stats = collider.gameObject.GetComponent<PlayerStats>();
            stats.CollectMush(this.mushValue);
            Destroy(this.gameObject);
        }
    }
}
