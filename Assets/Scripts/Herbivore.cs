using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herbivore : MonoBehaviour, CharacterBehavior
{
    public Transform movepoint;
    private float speed = 1f;
    public LayerMask stopMovement;
    private int distance = 2;
    private int bounds = 12;
    
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        movepoint.parent = null;
        InvokeRepeating("Move", 1.0f, .4f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Move()
    {
        int horizontal = Random.Range(0 - distance + 1, distance);
        int vertical = Random.Range(0 - distance + 1, distance);
        Vector3 movement = new Vector3(horizontal, 0f, vertical);

           if ((transform.position + movement).x > 10)
            {
            int temp = Random.Range(-1, 1);
            movement.x = temp;

            }
            if ((transform.position + movement).x < -10)
            {
            int temp = Random.Range(0, 2);
            movement.x = temp;

        }
            if ((transform.position + movement).z > 10)
            {

            int temp = Random.Range(-1, 1);
            movement.z = temp;

        }
            if ((transform.position + movement).z < -10)
            {
            int temp = Random.Range(0, 2);
            movement.z = 0;
        }
           
        transform.position += movement;
        
        //while(Mathf.Abs((transform.position +movement).x) > 12 || Mathf.Abs((transform.position + movement).z) > 12)
        //{
        //    horizontal = Random.Range(0 - distance, distance);
        //    vertical = Random.Range(0 - distance, distance);
        //    movement = new Vector3(horizontal, 0f, vertical);
        //    Debug.Log(movement);
        //}
    }
    void OnTriggerEnter(Collider col)
    {
        //if(col.bounds.center.x > 12)
        //{
        //    Vector3 movement = transform.position;
        //    movement.x = 11;
        //    Debug.Log(movement);
        //    transform.position = Vector3.MoveTowards(transform.position, movement, speed);
        //}
        //else if (col.bounds.center.x < -12)
        //{
        //    Vector3 movement = transform.position;
        //    movement.x = -11;
        //    Debug.Log(movement);
        //    transform.position = Vector3.MoveTowards(transform.position, movement, speed);
        //}
        //if (col.bounds.center.z > 12)
        //{
        //    Vector3 movement = transform.position;
        //    movement.z = 11;
        //    Debug.Log(movement);
        //    transform.position = Vector3.MoveTowards(transform.position, movement, speed);
        //}
        //else if (col.bounds.center.z < -12)
        //{
        //    Vector3 movement = transform.position;
        //    movement.z = -11;
        //    Debug.Log(movement);
        //    transform.position = Vector3.MoveTowards(transform.position, movement, speed);
        //}

        
    }
}
