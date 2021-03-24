using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour 
{
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "p1_door")
		{
			SceneManager.LoadScene("p2");
		}

		else if (coll.gameObject.tag == "p2_door")
		{
			SceneManager.LoadScene("p3");
		}

		else if (coll.gameObject.tag == "p3_door")
		{
			SceneManager.LoadScene("p4");
		}

		else if (coll.gameObject.tag == "p4_door")
		{
			SceneManager.LoadScene("game_end");
		}

	}

}
