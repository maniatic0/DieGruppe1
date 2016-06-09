using UnityEngine;
using System.Collections;

public class movimientoBola : MonoBehaviour {
    private Rigidbody2D body;
    public float iniVel;
    public Collider2D goalP1;
    public Collider2D goalP2;
    private Vector3 iniPos;
    public pongManager manager;
    // Use this for initialization
    void Start () {
        iniPos = transform.position;
        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(iniVel, 0);
        if (Random.Range(0, 2) == 0)
        {
            body.velocity = -1 * body.velocity;
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Barra") {
            body.velocity = new Vector2(-body.velocity.x, body.velocity.y + coll.gameObject.GetComponent<Rigidbody2D>().velocity.y);
        }
        else if (coll.gameObject.tag == "Pared")
        {
            body.velocity = new Vector2(body.velocity.x, -body.velocity.y);
        }
        else if (coll.gameObject.tag == "Meta")
        {
            body.velocity = Vector2.zero;
            transform.position = iniPos;
            body.velocity = new Vector2(iniVel, 0);
            if (coll == goalP1)
            {
                body.velocity = -1 * body.velocity;
                manager.increaseScoreP1();
            }
            else
            {
                manager.increaseScoreP2();
            }
        }
    }
}
