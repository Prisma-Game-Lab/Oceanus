using UnityEngine;
using System.Collections;

public class PlayerShooting : ShootingScript
{

    private Transform _torso;
    private Animator _torsoAnimator;

    void Awake()
    {
        _torso = transform.Find("Torso");
       _torsoAnimator= _torso.GetComponent<Animator>();
    }

    public override void Shoot()
    {
        _canShoot = false;
        _torsoAnimator.SetTrigger("Shot");
        Invoke("SetShootOn", 1 / rateOfFire);
    }

    public void SpawnBullet()
    {
        Rigidbody2D rigid = ((GameObject)Instantiate(bullet, BulletSpawn.transform.position, transform.rotation)).GetComponent<Rigidbody2D>();
        PrepareBullet(rigid);
    }

    internal override void PrepareBullet(Rigidbody2D rigid)
    {
        rigid.velocity = (Vector2)_torso.right.normalized * bulletVelocity;
    }

}
