using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContriller : MonoBehaviour
{
    public Rigidbody player;
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
    if (right)
        {
            player.transform.Rotate(100 * Time.deltaTime,0,0, Space.World);
            player.velocity = new Vector3(0f, 0f,speed * Time.deltaTime);
        }
    else
        {
            player.transform.Rotate(0, 0, -100 * Time.deltaTime, Space.World);
            player.velocity = new Vector3(speed * Time.deltaTime,0f, 0f);
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
