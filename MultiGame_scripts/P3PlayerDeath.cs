using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]

public class P3PlayerDeath : MonoBehaviour 
{

    public AudioClip GameOver;
    private AudioSource audio;
    float delay = 2.0f;
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }
    
    
    void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
            coll.isTrigger = false;
            audio.PlayOneShot(GameOver);
            if (Application.loadedLevelName == "p1")
            {
                SceneManager.LoadScene("table");
            }
            if (Application.loadedLevelName == "p2")
            {
                SceneManager.LoadScene("table");
            }
            if (Application.loadedLevelName == "p3")
            {
                SceneManager.LoadScene("table");
            }

			if (Application.loadedLevelName == "p4")
			{
				SceneManager.LoadScene("table");
			}



        }
	}

}
