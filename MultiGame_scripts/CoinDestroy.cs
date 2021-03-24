using UnityEngine;
using System.Collections;

public class CoinDestroy : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll) {
        CoinPickingPlayer.coincounter++;
        Destroy(gameObject);
    }
}