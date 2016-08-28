using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;

	private Transform myTransform;
	private Rigidbody2D _rigidbody;

	// Use this for initialization
	void Awake() {
		myTransform = transform;
		_rigidbody = GetComponent<Rigidbody2D>();
	}

	void Start () {
	}

	// Update is called once per frame
	void Update () {    
		Vector3 dir = target.position - myTransform.position;
		if (dir != Vector3.zero) {
			float angle = Mathf.Atan2 (dir.y, dir.x)*Mathf.Rad2Deg;
			_rigidbody.MoveRotation (Mathf.MoveTowardsAngle(_rigidbody.rotation,angle,rotationSpeed*Time.deltaTime));
				
			//myTransform.rotation = Quaternion.Slerp (myTransform.rotation, 
				//Quaternion.FromToRotation(Vector3.right, dir), rotationSpeed * Time.deltaTime);
		}


		//myTransform.position += (target.position - myTransform.position).normalized * moveSpeed * Time.deltaTime;
		_rigidbody.velocity = dir.normalized * moveSpeed;
	}
}
