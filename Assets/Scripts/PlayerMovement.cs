using UnityEngine;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    public float speed = 10f;
    public float turningSpeed = 90f;
    private Rigidbody2D _rigidBody;
    private GameObject _legs;
    private GameObject _torso;
    private Animator _torsoAnimator;

    /*private float _power = 8000f;

    public float power{ get { return _power; } }*/

    public Vector3 LookingAngle
    {
        get
        {
            //return new Vector3(Mathf.Cos(_rigidBody.rotation), Mathf.Sin(_rigidBody.rotation), 0f);
            float x, y;
            x = Mathf.Cos(_torso.transform.rotation.eulerAngles.z);
            y = Mathf.Sin(_torso.transform.rotation.eulerAngles.z);
            return new Vector3(x, y, 0f);
        }
    }

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _torso = transform.Find("Torso").gameObject;
        _legs = transform.Find("Legs").gameObject;
        _torsoAnimator = _torso.GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x, y;
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        turningFunction();
        moveFunction(x, y);
    }

    void moveFunction(float x, float y)
    {
        Vector3 movement = new Vector3(x, y, 0f);
        movement = movement.normalized;
        //movement *= speed * Time.deltaTime;
        _rigidBody.velocity = speed * movement;

        if (x != 0f || y != 0f)
        {
            _torsoAnimator.SetBool("isMoving",true);
            _legs.transform.rotation = Quaternion.RotateTowards(_legs.transform.rotation,
                Quaternion.AngleAxis(Mathf.Atan2(movement.y, movement.x)*Mathf.Rad2Deg, Vector3.forward),
                Time.deltaTime*turningSpeed);
        }
        else
        {
            _torsoAnimator.SetBool("isMoving",false);
        }
    
    }

    void turningFunction()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse = new Vector3(mouse.x, mouse.y, 0f);
        float angle;
        Vector3 dist = mouse - transform.position;
        angle = Mathf.Atan2(dist.y, dist.x) * Mathf.Rad2Deg;

        _torso.transform.rotation = Quaternion.RotateTowards(_torso.transform.rotation,
            Quaternion.AngleAxis(angle, Vector3.forward), Time.deltaTime * turningSpeed);
    }
}
