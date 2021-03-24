using UnityEngine;
using System.Collections;

public class CoinsPickingPlayer : MonoBehaviour {

    public static int coincounter = 0;

    public Font f;
    void OnGUI()
    {
        string tekstMonety = "Coins: " + coincounter;
        GUIStyle boxStyle = "box";
        boxStyle.font = f;
        GUI.backgroundColor = new Color(0, 0, 0, 0);

        GUI.Box(new Rect(Screen.width - 200, 20, 180, 25), tekstMonety,boxStyle);
    }
}
