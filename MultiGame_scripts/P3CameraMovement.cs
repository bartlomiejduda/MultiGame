using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class P3CameraMovement : MonoBehaviour 
{
    private Vector3 m_LevCam;
    public static float m_CamSpeed;

	public float walkSpeed = 2.0f;
	public float wallLeft = 0.0f;
	public float wallRight = 999.0f;
	float walkingDirection = 1.0f;
	Vector3 walkAmount;

	void Start () 
    {
		m_CamSpeed = 1.25f;
	}

	void Update () 
    {
		m_LevCam = gameObject.transform.position;
		if (Application.loadedLevelName == "p3") 
		{
			gameObject.transform.position = new Vector3 (0f, m_LevCam.y + m_CamSpeed * Time.deltaTime, -10f);
		}
		if (Application.loadedLevelName == "p4") 
		{

			walkAmount.x = 1.0f * 2.0f * Time.deltaTime;
			if (walkingDirection > 0.0f && transform.position.x >= wallRight)
				walkingDirection = -1.0f;
			else if (walkingDirection < 0.0f && transform.position.x <= wallLeft)
				walkingDirection = 1.0f;
			transform.Translate(walkAmount);
		}
        if (Application.loadedLevelName == "p1")
        {



            walkAmount.x = 1.0f * 2.0f * Time.deltaTime;
            if (walkingDirection > 0.0f && transform.position.x >= wallRight)
                walkingDirection = -1.0f;
            else if (walkingDirection < 0.0f && transform.position.x <= wallLeft)
                walkingDirection = 1.0f;
            transform.Translate(walkAmount);
            Debug.Log("p1 kam");
        }
    }

    public static void SpeedUpCamera()
    {
		if (m_CamSpeed < 18f)
        {
			m_CamSpeed += 1f;
        }
    }

    public float GetCameraSpeed()
    {
		return m_CamSpeed;
    }
}
