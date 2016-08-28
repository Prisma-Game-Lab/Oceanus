using UnityEngine;
using System.Collections;

public class PlayerLife : MonoBehaviour {
    //Variables
    public int MaxLife = 100;
    private int _curLife;

	// Use this for initialization
	void Start ()
	{
	    _curLife = MaxLife;
	}
	
	// Update is called once per frame
	void Update () {
	    //Debug.Log(_curLife);
	}

    void KillPlayer()
    {
        Debug.Log("MORREU");
    }

    void TakeShoot()
    {
        _curLife -= 50;
        Debug.Log(_curLife);
        if (_curLife <= 0)
        {
            KillPlayer();
        }
    }
}