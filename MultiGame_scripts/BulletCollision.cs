using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour 
{
	void OnCollisionEnter2D(Collision2D coll)
	{ 
		if (coll.gameObject.tag == "right_tag") {
			Destroy (coll.gameObject);
		}
	}
}
