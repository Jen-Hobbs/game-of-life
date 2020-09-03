using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herbivore : MonoBehaviour, CharacterBehavior
{
    public Transform movepoint;
    private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        movepoint.parent = null;
        InvokeRepeating("Move", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Move()
    {
        System.Random rnd = new System.Random();
        int horizontal = rnd.Next(0, 3) -1;
        int vertical = rnd.Next(0, 3) -1;
        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        transform.position += Vector3.MoveTowards(transform.position, movement, speed);
    }
}
