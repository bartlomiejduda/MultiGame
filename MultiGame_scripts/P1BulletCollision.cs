using UnityEngine;
using System.Collections;

public class P1BulletCollision : MonoBehaviour 
{
	public Transform bulletPrefab;

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "enemy") 
		{
			Destroy (coll.gameObject);
			Destroy (gameObject);  
		} 

		else 
		{
			Destroy (gameObject);
		}


	}
}
