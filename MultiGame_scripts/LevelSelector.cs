using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
     void OnGUI()
     {
        GUI.backgroundColor = new Color(0, 0, 0, 0);

        GUI.Box(new Rect(10, 10, 100, 190), "Levels");

         if (GUI.Button(new Rect(20, 40, 80, 20), "Menu"))
         {
             SceneManager.LoadScene("menu");
         }

         if (GUI.Button(new Rect(20, 70, 80, 20), "Level 1"))
         {
             SceneManager.LoadScene("p1");
         }

     }

   



}