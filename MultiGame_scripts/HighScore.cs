using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour 
{
	public string scoreText;
	public float score;
	public string HighScoreText;


	void Start () 
	{
		scoreText = "Score: " + score.ToString();
	}
			
	void Update () 
	{
		HighScoreText = "Best: " + PlayerPrefs.GetInt("highscore");
		SaveScore(CoinPickingPlayer.coincounter);

	}


	void SaveScore(int newResult)
	{
		int oldResult = PlayerPrefs.GetInt("highscore", 0);    
			if(newResult > oldResult)
		{
				PlayerPrefs.SetInt("highscore", newResult);
				HighScoreText = scoreText;
		}

		PlayerPrefs.Save(); 

	}





}