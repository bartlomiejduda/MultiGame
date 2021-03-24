using UnityEngine;
using System.Collections;

public class DestroyingCoins : MonoBehaviour
{
    public int minX, maxX, minY, maxY;

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "wall_multi")
        {
            gameObject.transform.position = Position();
        }

        else if (coll.gameObject.tag == "Player" && gameObject.tag == "coin_multi")
        {
            gameObject.transform.position = Position();
            P1_MULTI_COINPICKING.coincounter++; 

        }

        else if (coll.gameObject.tag == "Graczz" && gameObject.tag == "fruit_multi")
        {
            gameObject.transform.position = Position();
            P1_MULTI_COINPICKING.fruitcounter++;

        }

        else if (coll.gameObject.tag == "Player" && gameObject.tag == "fruit_multi")
        {
            gameObject.transform.position = Position();
            P1_MULTI_COINPICKING.fruitcounter++;

        }


        else if (coll.gameObject.tag == "Player" && gameObject.tag == "coin_multi")
        {
            gameObject.transform.position = Position();
            P1_MULTI_COINPICKING.fruitcounter++;

        }
    }


    Vector3 Position()
    {
        int x, y;
        x = UnityEngine.Random.Range(minX, maxX);
        y = UnityEngine.Random.Range(minY, maxY);
        return new Vector3(x, y, 0);
    }


}