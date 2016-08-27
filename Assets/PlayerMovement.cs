using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    //Variables
    public float speed = 10f;
    private Rigidbody2D _rigidBody;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
	    float x, y;
	    x = Input.GetAxisRaw("Horizontal");
	    y = Input.GetAxisRaw("Vertical");

        moveFunction(x, y);
        turningFunction();
	}

    void moveFunction(float x, float y)
    {
        Vector3 movement = new Vector3(x, y, 0f);
        movement = movement.normalized;
        movement *= speed * Time.deltaTime;
        _rigidBody.MovePosition(transform.position + movement);
    }

    void turningFunction()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse = new Vector3(mouse.x,mouse.y,0f);
        float angle;
        Vector3 dist = mouse - transform.position;
        Debug.Log(dist);
        angle = Mathf.Atan2(dist.y, dist.x);
        _rigidBody.MoveRotation(angle * Mathf.Rad2Deg);
    }
}
