using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour 
{

	void OnGUI()
	{
		

		if (GUI.Button(new Rect(400, 650, 80, 20), "New Game"))
		{
			SceneManager.LoadScene("menu");
		}
			
		if (GUI.Button(new Rect(700, 650, 80, 20), "Exit Game"))
		{
			Application.Quit();
		}
	}

}