using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public float RangeDistance;
    public float RangeAngle;
    private EnemyShooting _enShooting;
    private float _distance;
    private EnemyMovement _move;

    void Awake()
    {
        _enShooting = GetComponent<EnemyShooting>();
        _move = GetComponent<EnemyMovement>();
        RangeDistance = 10f;
        RangeAngle = 30f;
        Debug.Log(RangeAngle);
        Debug.Log(RangeDistance);
    }

	// Update is called once per frame
	void Update ()
	{
	    _distance = (transform.position - _move.target.position).magnitude;

	    if (_enShooting.canShoot == true && (_distance <= RangeDistance) && CanSee())
	    {
	        _enShooting.Shoot();
	    }
	}

    bool CanSee()
    {
        float Looking = transform.rotation.eulerAngles.z;
        float Diff = Vector3.Angle(Vector3.right, _move.target.position - transform.position);
        Debug.Log(Looking);
        Debug.Log(Diff);
        return (Mathf.Abs(Diff - Looking) <= RangeAngle);
    }
}
