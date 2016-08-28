using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
	void Update () {
	
	}

    void KillEnemy(float time)
    {
       Destroy(this.gameObject,time); 
        Debug.Log("TEU CU");
    }
}
 