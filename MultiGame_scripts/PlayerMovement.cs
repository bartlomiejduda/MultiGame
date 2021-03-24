using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float speed_LP = 5;
	public float speed_GD = 5;
	[Range(0, 1)]
	public float sliding = 0.9f;
	public float jump_force = 1200;
	private Animator animator;


	bool IsOnGround()
	{
		Bounds b_bounds = GetComponent<Collider2D>().bounds; 
		float d_distance = b_bounds.size.y * 0.1f; 
		Vector2 v = new Vector2(b_bounds.center.x, b_bounds.min.y - d_distance);
		RaycastHit2D hit = Physics2D.Linecast(v, b_bounds.center);

		return (hit.collider.gameObject != gameObject);
	}

	void FixedUpdate() 
	{
		animator = GetComponent<Animator>();
		bool szesc = Input.GetKey("6");
		bool cztery = Input.GetKey("4");
		Vector2 v = GetComponent<Rigidbody2D>().velocity; 


			if (Input.GetKey(KeyCode.End))
			{

				GetComponent<Rigidbody2D>().AddForce(Vector2.down * speed_GD);
				animator.SetTrigger("down");

			}
		if (Input.GetKey(KeyCode.Home))
			{

				GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed_GD);
				animator.SetTrigger("up");

			}

		if (Input.GetKey(KeyCode.Delete))
		{
            float v1 = -0.82f;
			GetComponent<Rigidbody2D>().velocity = new Vector2(v1 * speed_LP, v.y);
			transform.localScale = new Vector2(Mathf.Sign(v1), transform.localScale.y);
			animator.SetTrigger("run");                     

		}

		if (Input.GetKey(KeyCode.PageDown))
		{

            float v2 = 0.82f;
            GetComponent<Rigidbody2D>().velocity = new Vector2(v2 * speed_LP, v.y);
			transform.localScale = new Vector2(Mathf.Sign(v2), transform.localScale.y);
			animator.SetTrigger("run");                     

		}

		GetComponent<Animator>().SetFloat("Speed", Mathf.Abs(1));
        
    }



}