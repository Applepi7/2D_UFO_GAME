using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public static PlayerController instance;

    public float speed = 10;
    public int score = 0;

    private Rigidbody2D rigidbody;
    private float moveHorizontal;
    private float moveVertical;
    private Vector2 movement;

	// Use this for initialization
	void Start () {
        instance = this;
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        movement = new Vector2(moveHorizontal, moveVertical);

        rigidbody.AddForce(movement * speed);
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("PickUp"))
        {
            col.gameObject.SetActive(false);
            score += 1;
        }
    }
}
