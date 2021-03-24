using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

    public string IntroText =
        @"Pomysł:
         Twoim celem w grze jest przejście kilku poziomów o zróżnicowanym
         poziomie trudności. Każdy następny poziom różni się od poprzedniego
         i gra staje się coraz trudniejsza.

         Fabuła:
         Jesteś dzielnym poszukiwaczem przygód, który nie boi się wyzwań.
         Próbujesz zdobyć mistyczny artefakt, który znajduje się na samym końcu gry.
         Losy świata spoczywają na twoich barkach

         Sterowanie: 
         Strzałka w lewo - ruch w lewo
         Strzałka w prawo - ruch w prawo
         Strzałka w górę - skok

         Powodzenia!";

    public Font f;
    void OnGUI()
    {
        
        GUIStyle boxStyle = "box";
        boxStyle.font = f;
        GUI.backgroundColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        boxStyle.wordWrap = true;
        GUI.skin.box.alignment = TextAnchor.MiddleLeft;
        GUI.Box(new Rect(550, 100, 600, 300), @"Pomysł:
         Twoim celem w grze jest przejście kilku poziomów o zróżnicowanym
         poziomie trudności.
         Każdy następny poziom różni się od poprzedniego
         i gra staje się coraz trudniejsza.

         Fabuła:
         Jesteś dzielnym poszukiwaczem przygód, który nie boi się wyzwań.
         Próbujesz zdobyć mistyczny artefakt, który znajduje się na samym końcu gry.
         Losy świata spoczywają na twoich barkach

       Sterowanie:
        Strzałka w lewo - ruch w lewo
        Strzałka w prawo - ruch w prawo
        Strzałka w górę - skok

         Powodzenia!", boxStyle);


        if (GUI.Button(new Rect(820, 420, 150, 25), "Start Game!", boxStyle))
        {
            SceneManager.LoadScene("p1");
        }
    }
}
