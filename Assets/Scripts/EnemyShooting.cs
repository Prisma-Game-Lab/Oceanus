using System;
using UnityEngine;
using System.Collections;

public class EnemyShooting : ShootingScript
{
    //private Transform _enemyTransform;

    void Awake()
    {
        //_enemyTransform = transform.Find("Enemy");
    }

    internal override void PrepareBullet(Rigidbody2D rigid)
    {
        rigid.velocity = (Vector2)transform.right.normalized * bulletVelocity;
    }
}
