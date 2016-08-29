using UnityEngine;
using System.Collections;

public class BulletCollisionScript : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Äqui");

        if (coll.gameObject.tag == "EnemyType1" || coll.gameObject.tag == "EnemyType2")
        {

            Debug.Log("Coliided");
            coll.gameObject.SendMessage("KillEnemy", 0.001f);
        }
        else if (coll.gameObject.tag == "Player")
        {
            Debug.Log("FDP");
            coll.gameObject.SendMessage("TakeShoot");
        }
        else if (coll.gameObject.tag == "Building")
        {
            if (coll.gameObject.name == "Estufa")
            {
                coll.gameObject.SendMessage("TakeShootEstufa");
            }
            else if (coll.gameObject.name == "Usina")
            {
                coll.gameObject.SendMessage("TakeShootUsina");
            }
            else if (coll.gameObject.name == "Prefeitura")
            {
                coll.gameObject.SendMessage("TakeShootPrefeitura");
            }
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