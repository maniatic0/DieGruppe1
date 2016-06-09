using UnityEngine;
using System.Collections;

public class movimientoBarra : MonoBehaviour {
    public float maxY;
    public float minY;
    public float maxVel;
    public float force;
    public string boton;
    private bool botonUpPressed = false;
    private bool botonDownPressed = false;
    private int moving = 0;
    private Rigidbody2D body;
    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        botonUpPressed = Input.GetAxisRaw(boton) == 1;
        botonDownPressed = Input.GetAxisRaw(boton) == -1;
    }

    void FixedUpdate()
    {
        if (botonUpPressed && !botonDownPressed && Mathf.Abs(body.velocity.y) <= maxVel && transform.position.y < maxY)
        {
            if (moving != 1)
            {
                moving = 1;
                body.velocity = Vector2.zero;
            }
            body.AddForce(new Vector2(0, force));
        }
        else if (!botonUpPressed && botonDownPressed && Mathf.Abs(body.velocity.y) <= maxVel && transform.position.y > minY)
        {
            if (moving != -1)
            {
                moving = -1;
                body.velocity = Vector2.zero;
            }
            body.AddForce(new Vector2(0, -force));
        }
        else {
            if (moving != 0)
            {
                body.velocity = Vector2.zero;
                moving = 0;
            }
        }
    }
}
