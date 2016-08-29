using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;

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
	void Update ()
	{
	    if (GameObject.FindGameObjectWithTag("Building") == null)
	        KillPlayer();
	}

    void KillPlayer()
    {
        Debug.Log("MORREU");
        SceneManager.LoadScene("GameOverScreen");
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