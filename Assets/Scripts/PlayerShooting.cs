using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	public float rateOfFire;
    public float bulletVelocity;
	bool _canShoot = true;
    public GameObject bullet;

    public GameObject [] BubbleBullets;

    public GameObject BulletSpawn;

    void Shoot()

    {
        Rigidbody2D rigid = ((GameObject)Instantiate(bullet, BulletSpawn.transform.position, transform.rotation)).GetComponent<Rigidbody2D>();
        rigid.velocity = (Vector2)transform.right.normalized * bulletVelocity;
    }

    void SetShootOn ()
    {
            _canShoot = true;
        
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
        
         if (_canShoot == true && Input.GetMouseButton(0))
        {
            Shoot();
            _canShoot = false;
            Invoke("SetShootOn", 1 / rateOfFire);
        }
	
	}
}
