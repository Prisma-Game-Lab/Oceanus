using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public float RangeDistance;
    public float RangeAngle;
    public float DistanceLimit;
    private EnemyShooting _enShooting;
    private float _distance;
    private EnemyMovement _move;
    [SerializeField] private RaycastHit2D hit;
    public int SlowDownSpeed;

    void Awake()
    {
        _enShooting = GetComponent<EnemyShooting>();
        _move = GetComponent<EnemyMovement>();
        // RangeDistance = 10f;
        // RangeAngle = 30f;
        Debug.Log(RangeAngle);
        Debug.Log(RangeDistance);
    }

	// Update is called once per frame
	void Update ()
	{
	    _distance = (transform.position - _move.target.position).magnitude;
        Debug.DrawRay(_enShooting.BulletSpawn.transform.position, _enShooting.BulletSpawn.transform.right * RangeDistance);
        if (_enShooting.canShoot == true && CanSee())
	    {
	        if (gameObject.tag == "EnemyType1")
	        {
	            if (hit.collider.tag == "Player")
	            {
	                _enShooting.Shoot();

	                if (_move.moveSpeed > SlowDownSpeed)
	                    _move.moveSpeed = SlowDownSpeed;
                    if (hit.distance <= DistanceLimit)
                        _move.moveSpeed = 0;
                }
	        }
            else if (gameObject.tag == "EnemyType2")
            {
                if (hit.collider.tag == "Building")
                {
                    Debug.Log(hit.collider.tag);
                    _enShooting.Shoot();
                    if (_move.moveSpeed > SlowDownSpeed)
                        _move.moveSpeed = SlowDownSpeed;
                    if (hit.distance <= DistanceLimit)
                        _move.moveSpeed = 0;
                }
            }
	    }
	}

    bool CanSee()
    {
        /*
        float Looking = transform.rotation.eulerAngles.z;
        float Diff = Vector3.Angle(Vector3.right, _move.target.position - transform.position);
        Debug.Log(Looking);
        Debug.Log(Diff);
        return (Mathf.Abs(Diff - Looking) <= RangeAngle);
        */
        hit = Physics2D.Raycast(_enShooting.BulletSpawn.transform.position, _enShooting.BulletSpawn.transform.right,
            RangeDistance);
        
        return hit;

    }
}
