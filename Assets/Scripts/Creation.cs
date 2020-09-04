using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creation : MonoBehaviour
{
    public int quantity;
    public Transform parent;
    public GameObject herbivore;

    // Start is called before the first frame update
    void Start()
    {
        //for(int x =0; x <= quantity; x++)
        {
            System.Random rnd = new System.Random();
            for(int x = 0; x < quantity; x++)
            {
                GameObject setHerbivore = GameObject.Instantiate(herbivore, setPosition(rnd), transform.rotation);
                setHerbivore.transform.SetParent(parent);
            }
            

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 setPosition(System.Random rnd)
    {
        float horizontal = rnd.Next(21) - 10;
        float vertical = rnd.Next(21) - 10;
        return new Vector3(horizontal, 0, vertical);
    }
}
