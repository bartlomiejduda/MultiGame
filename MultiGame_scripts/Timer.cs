using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]

public class Timer : MonoBehaviour
{

    float TimeLeft = 35.0f;
    bool onetime = false;
    public AudioClip GameOver;
    private AudioSource audio;
    public Font f;
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }


    void Update()
    {
        TimeLeft -= Time.deltaTime;
        
    }

    void OnGUI()
    {
        GUIStyle boxStyle = "box";
        boxStyle.font = f;
        GUI.backgroundColor = new Color(0, 0, 0, 0);

        if (TimeLeft > 0)
        {
            GUI.skin.box.alignment = TextAnchor.UpperLeft;
            GUI.Box(new Rect(Screen.width - 200, 50, 180, 25), "Time Left: " + (int)TimeLeft,boxStyle);
        }
        else {
            if (!onetime)
            {
                audio.PlayOneShot(GameOver);
                onetime = true;
            }
            GUI.skin.box.alignment = TextAnchor.UpperLeft;
            GUI.Box(new Rect(Screen.width - 200, 50, 180, 25), "End of time",boxStyle);
            GUI.skin.box.alignment = TextAnchor.MiddleCenter;
            GUI.color = Color.red;
            GUI.backgroundColor = new Color(1.0f, 1.0f, 1.0f, 0.5f);
            GUI.backgroundColor = Color.white;
            if (Application.loadedLevelName == "MULTI")
            {
                Debug.Log("empty");
            }
            else
            {
                GUI.Box(new Rect(Screen.width/2 - 100, 300, 200, 100), "You lose!", boxStyle);
            }
            if(Application.loadedLevelName == "MULTI")
            {
                Zbieranie_MULTI_P1.ZliczaniePunktow();
            }
            
            if (TimeLeft <= -4)
            {

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

                if (Application.loadedLevelName == "MULTI")
                {
                    SceneManager.LoadScene("table");

                }

                
            }

        }
    }
}