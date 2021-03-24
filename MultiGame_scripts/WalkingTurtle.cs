using UnityEngine;
using System.Collections;

public class WalkingTurtle : MonoBehaviour
{

    public Transform destination;
    public float speed = 2f;
    private float min_distance = 5f;
    private float distance;

    void Update()
    {
        distance = Vector2.Distance(transform.position, destination.position);
        if (distance < min_distance)
        {
            Vector3 dir = destination.position - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.position = Vector2.MoveTowards(transform.position, destination.position, speed * Time.deltaTime);

        }
    }


}