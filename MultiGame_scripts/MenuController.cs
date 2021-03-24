using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    int counter = 0;
    string name = "";
    int score_int = -1;
    string score = "";
    List<Scores> highscore;

    void Start()
    {
        highscore = new List<Scores>();
    }

    void ButtonClicked(GameObject _obj)
    {
        print("Clicked button:" + _obj.name);
    }

   
    

    void OnGUI()
    {
        UnityEngine.GUIStyle centeredStyle = GUI.skin.GetStyle("Label");
        centeredStyle.alignment = TextAnchor.UpperCenter;

        score = CoinsPickingPlayer.coincounter.ToString();
        score_int = CoinsPickingPlayer.coincounter;

        GUILayout.BeginHorizontal(); GUILayout.Label("", GUILayout.Width(500)); GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal(); GUILayout.Label("", GUILayout.Width(500)); GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal(); GUILayout.Label("", GUILayout.Width(500)); GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal(); GUILayout.Label("", GUILayout.Width(500)); GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal(); GUILayout.Label("", GUILayout.Width(500)); GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal(); GUILayout.Label("", GUILayout.Width(500)); GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal(); GUILayout.Label("", GUILayout.Width(500)); GUILayout.EndHorizontal();



        GUILayout.BeginHorizontal();
        GUILayout.Label("", GUILayout.Width(500));
        GUILayout.Label("Enter Name:", GUILayout.Width(100));
        name = GUILayout.TextField(name, GUILayout.Width(100));
        GUILayout.EndHorizontal();


        GUILayout.BeginHorizontal();
        GUILayout.Label("", GUILayout.Width(500));
        GUILayout.Label("Your Score:" + score, GUILayout.Width(100));
        GUILayout.EndHorizontal();


        GUILayout.BeginHorizontal();
        GUILayout.Label("", GUILayout.Width(500));
        if (GUILayout.Button("Add Result", GUILayout.Width(100)) && counter <= 0 && score_int != 0)
        {

            HighScoreManager._instance.SaveHighScore(name, System.Int32.Parse(score));
            highscore = HighScoreManager._instance.GetHighScore();
            counter++;
            CoinsPickingPlayer.coincounter = 0;
            Zbieranie_MULTI_P1.counterMonet = 0;
            Zbieranie_MULTI_P1.counterMonet2 = 0;
        }

        if (GUILayout.Button("Exit to Main Menu", GUILayout.Width(100)))
        {
            SceneManager.LoadScene("menu");
        } 
        GUILayout.EndHorizontal();
        
        highscore = HighScoreManager._instance.GetHighScore();


        GUILayout.BeginHorizontal();
        GUILayout.Label("", GUILayout.Width(500));
        if (GUILayout.Button("Clear HighScore", GUILayout.Width(200)))
        {
            HighScoreManager._instance.ClearLeaderBoard();
        }
        GUILayout.EndHorizontal();

        GUILayout.Space(60);
        GUILayout.BeginHorizontal();
        GUILayout.Label("Position", GUILayout.Width((Screen.width / 3)));
        GUILayout.Label("Name", GUILayout.Width((Screen.width / 3)));
        GUILayout.Label("Points", GUILayout.Width((Screen.width / 3)));
        GUILayout.EndHorizontal();

        GUILayout.Space(25);
        int licz = 0;
        string licz_str = "";
        foreach (Scores _score in highscore)
        {
            licz++;
            licz_str = licz.ToString();
            GUILayout.BeginHorizontal();
            GUILayout.Label(licz_str, GUILayout.Width(Screen.width / 3));
            GUILayout.Label(_score.name, GUILayout.Width(Screen.width / 3));
            GUILayout.Label("" + _score.score, GUILayout.Width(Screen.width / 3));
            GUILayout.EndHorizontal();
        }
    }
}
