using UnityEngine; using System.Collections;


public class EnemiesMovement : MonoBehaviour {


	public float walkSpeed = 2.0f;
	public float wallLeft = 0.0f;
	public float wallRight = 5.0f;
	float walkingDirection = 1.0f;
	Vector3 walkAmount;
    private Animator animator;


	void Update () 
	{

        animator = GetComponent<Animator>();
        walkAmount.x = walkingDirection * walkSpeed * Time.deltaTime;
        
        if (walkingDirection > 0.0f && transform.position.x >= wallRight)
        {
            walkingDirection = -1.0f;
            animator.transform.localScale = new Vector3(1, 1, 1);

        }
        else if (walkingDirection < 0.0f && transform.position.x <= wallLeft)
        {
            walkingDirection = 1.0f;
            animator.transform.localScale = new Vector3(-1, 1, 1);
        }
		transform.Translate(walkAmount);
	}



} 