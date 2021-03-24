using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]

public class LifeBar : MonoBehaviour
{
    int Life = 100;
    float delay = 3;
    public Font f;
    public AudioClip GameOver;
    private AudioSource audio;
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemy")
        {
            if (Life > 0)
            {
                Life -= 20;
            }
        }

    }

    bool onetime = false;

    void Update()
    {
                       
        if (Life <= 0)
        {
            if (!onetime)
            {
                audio.PlayOneShot(GameOver);
                onetime = true;
            }
            delay -= Time.deltaTime;
            if (delay <= 0)
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
                if (Application.loadedLevelName == "p4")
                {
                    SceneManager.LoadScene("table");
                }
            }
        }
    }

    void OnGUI()
    {
        GUIStyle boxStyle = "box";
        boxStyle.font = f;
        GUI.color = Color.red;
        if (Life <= 0)
        {
            GUI.Box(new Rect(Screen.width - 900, 300, 350, 50), "You lose!",boxStyle);
        }
        GUI.HorizontalScrollbar(new Rect(500, 15, 200, 20), 0, Life, 0, 100);
    }



}



