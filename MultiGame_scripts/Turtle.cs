using UnityEngine;
using System.Collections;

public class Turtle : MonoBehaviour {

    public float speed = 3;
    Vector2 dir = Vector2.right;
    public float upForce = 800;

    void FixedUpdate() {
        GetComponent<Rigidbody2D>().velocity = dir * speed;
    }

    void OnTriggerEnter2D(Collider2D coll) {
        transform.localScale = new Vector2(-1 * transform.localScale.x,
                                                transform.localScale.y);
        dir = new Vector2(-1 * dir.x, dir.y);
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Player") {
            if (coll.contacts[0].point.y > transform.position.y) {
                GetComponent<Animator>().SetTrigger("Died");
                GetComponent<Collider2D>().enabled = false;
                dir = -Vector2.up;
                coll.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * upForce);
                Invoke("Die", 5);
            } 
        }
    }

    void Die() {
        Destroy(gameObject);
    }
}
