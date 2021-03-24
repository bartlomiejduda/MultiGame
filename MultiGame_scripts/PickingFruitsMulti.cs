using UnityEngine;
using System.Collections;

public class PickingFruitsMulti : MonoBehaviour
{

    public static int coinscounter = 0;
    public static int fruitscounter = 0;
    public static int coinscounter2 = 0;
    public static int fruitscounter2 = 0;
    public Font f;
    void OnGUI()
    {
        GUI.backgroundColor = new Color(0, 0, 0, 0);
        if (gameObject.tag == "Player")
        {
            string CoinsText = "Coins: " + coinscounter;
            GUIStyle boxStyle = "box";
            boxStyle.font = f;
            GUI.Box(new Rect(Screen.width - 1000, 20, 180, 25), CoinsText, boxStyle);

            string FruitsText = "Fruits: " + fruitscounter;
            GUI.Box(new Rect(Screen.width - 1000, 50, 180, 25), FruitsText, boxStyle);

        }

        else if (gameObject.tag == "Player2")
        {
            string CoinsText = "Coins: " + coinscounter2;
            GUIStyle boxStyle = "box";
            boxStyle.font = f;
            GUI.Box(new Rect(Screen.width - 450, 20, 180, 25), CoinsText, boxStyle);

            string FruitsText = "Fruits: " + fruitscounter2;
            GUI.Box(new Rect(Screen.width - 450, 50, 180, 25), FruitsText, boxStyle);


        }

    }

    public static void CountingPoints()
    {
        float P1_score = coinscounter + 2 * fruitscounter;
        float P2_score = coinscounter2 + 2 * fruitscounter2;
        GUIStyle boxStyle = "box";
        GUI.backgroundColor = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        GUI.backgroundColor = Color.white;
        if (P1_score > P2_score)
        {
            string p1_win = "P1 wins with result: " + P1_score;
            CoinsCollectingPlayer.coinscountert = (int)P1_score;
            GUI.Box(new Rect(Screen.width - 720, 200, 300, 40), p1_win, boxStyle);
        }
        else if (P2_score > P1_score)
        {
            string p2_wygral = "P2 wins with result: " + P2_score;
            CoinsCollectingPlayer.coinscountert = (int)P2_score;
            GUI.Box(new Rect(Screen.width - 720, 200, 300, 40), p2_wygral, boxStyle);
        }

        else
        {
            string remis = "Draw! Both players had " + P1_score + " points.";
            GUI.Box(new Rect(Screen.width - 720, 200, 300, 40), remis, boxStyle);
        }


    }
}
