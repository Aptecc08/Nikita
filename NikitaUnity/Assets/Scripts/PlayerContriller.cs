using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContriller : MonoBehaviour
{
    public GameObject player;
    public int speed = 5;
    public int vect;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
    player.transform.Rotate(0, 0, 1000 * Time.deltaTime);
    player.transform.position += transform.forward * speed * Time.deltaTime;
    vect = 1;
    if (Input.GetMouseButtonDown(1))
            click();
    }

    public void click()
    {
        if (vect == 1)
        {
            player.transform.position += transform.up * speed * Time.deltaTime;
            vect = 0;
        }
        else if (vect == 0)
        {
            player.transform.position += transform.forward * speed * Time.deltaTime;
            vect = 1;
        }
    }

   
}
