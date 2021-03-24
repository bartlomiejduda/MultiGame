using UnityEngine;
using System.Collections;

public class EnemyRunFrom : MonoBehaviour
{

    public Transform target;
    public float speed = 2f;
    private float minDistance = 1.5f;
    private float range;

    void Update()
    {
        
        range = Vector2.Distance(target.transform.position, transform.position);
        if ( range < minDistance)
        {
            Vector3 dir = transform.position - target.transform.position;

            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


            Vector2 direction = transform.position - target.transform.position;
            direction.Normalize();
            transform.position = Vector2.MoveTowards(transform.position, direction * minDistance, Time.deltaTime * speed);
        }


    }
}