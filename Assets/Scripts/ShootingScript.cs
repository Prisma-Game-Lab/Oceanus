using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{

    public float rateOfFire;
    public float bulletVelocity;
    internal bool _canShoot = true;
    public bool canShoot {
        get { return _canShoot; }
    }
    public GameObject bullet;
    public GameObject BulletSpawn;

    public virtual void Shoot()
    {
        _canShoot = false;
        Invoke("SetShootOn", 1/rateOfFire);
        Rigidbody2D rigid = ((GameObject)Instantiate(bullet, BulletSpawn.transform.position, transform.rotation)).GetComponent<Rigidbody2D>();
        PrepareBullet(rigid);
    }
    internal virtual void PrepareBullet(Rigidbody2D rigid)
    {
    }

    void SetShootOn()
    {
        _canShoot = true;

    }

}
