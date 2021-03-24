using UnityEngine;
using System.Collections;

public class TurtleDestroy: MonoBehaviour {

	public bool byTime;
	public bool byContact;
	public float destroyTime;

	void Start () {

		Destroy (this.gameObject, destroyTime);
	}
	

	void OnTriggerStay2D(Collider2D other)
	{
		if(other.tag!="shooter" && other.tag!="neutralized")
		Destroy (this.gameObject);

	}
}
