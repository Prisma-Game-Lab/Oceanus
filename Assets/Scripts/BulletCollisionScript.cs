using UnityEngine;
using System.Collections;

public class BulletCollisionScript : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Äqui");

        if (coll.gameObject.tag == "Enemy")
        {

            Debug.Log("Coliided");
            coll.gameObject.SendMessage("KillEnemy", 0.5f);
        }
        else if (coll.gameObject.tag == "Player")
        {
            Debug.Log("FDP");
            coll.gameObject.SendMessage("TakeShoot");
        }
        else //(coll.gameObject.tag == "MaxRange")
        {
            Debug.Log("porra funciona");
            Destroy(this.gameObject);

        }
        Debug.Log("O viado");
        Destroy(this.gameObject);
    }

}