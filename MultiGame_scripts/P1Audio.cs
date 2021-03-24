using UnityEngine; 
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class P1Audio : MonoBehaviour 
{ 

	void Start() 
	{
		audio = GetComponent<AudioSource>();
	}

	public AudioClip Hit;
	AudioSource audio;

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag=="Player")
		{
			audio.PlayOneShot(Hit, 0.7F);
		}
	}




}