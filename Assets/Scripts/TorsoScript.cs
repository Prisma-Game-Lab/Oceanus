using UnityEngine;
using System.Collections;

public class TorsoScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shot()
    {
        transform.parent.GetComponent<PlayerShooting>().SpawnBullet();
    }
}