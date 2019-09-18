using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContriller : MonoBehaviour
{
    public GameObject player;
    public int speed = 5;
    public bool right;


    // Start is called before the first frame update
    void Start()
    {
        right = true;
    }

    // Update is called once per frame 
    void Update()
    {
    if (right == true)
        {
            player.transform.Rotate(0, 0, 100 * Time.deltaTime);
            player.transform.position += transform.forward* speed * Time.deltaTime;
        }
    else
        {
            player.transform.Rotate(0, 0, 100 * Time.deltaTime);
            player.transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetMouseButtonDown(1))
            click();
    }

    public void click()
    {
        if (right == true)
            right = false;
        else
            right = true;
    }

   
}
