using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;

public class UsinaLife : MonoBehaviour
{
    //Variables
    public int MaxLife = 100;
    private int _curLife;

    // Use this for initialization
    void Start()
    {
        _curLife = MaxLife;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(_curLife);
    }

    void KillUsina()
    {
        Debug.Log("Usina");
        GameObject[] Kill = GameObject.FindGameObjectsWithTag("EnemyType2");
        foreach (GameObject enemyType2 in Kill)
        {
            Destroy(enemyType2);
        }
        Destroy(this.gameObject);
        // SceneManager.LoadScene("GameOverScreen");
    }

    void TakeShootUsina()
    {
        _curLife -= 50;
        Debug.Log(_curLife);
        if (_curLife <= 0)
        {
            KillUsina();
        }
    }
}