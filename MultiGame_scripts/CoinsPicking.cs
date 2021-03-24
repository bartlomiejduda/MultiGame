using UnityEngine;
using System.Collections;

public class CoinsPicking : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            CoinPickingPlayer.coincounter++;
            Destroy(this.gameObject);
        }
    

    }


}
