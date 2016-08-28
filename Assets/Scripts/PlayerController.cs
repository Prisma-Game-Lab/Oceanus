using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private PlayerShooting _plShoot;

    void Awake()
    {
        _plShoot = GetComponent<PlayerShooting>();
    }
	// Update is called once per frame
	void Update ()
	{
        
         if (_plShoot.canShoot == true && Input.GetMouseButton(0))
        {
            _plShoot.Shoot();
        }
	
	}
	}
