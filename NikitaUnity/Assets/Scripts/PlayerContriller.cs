using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContriller : MonoBehaviour
{
    public GameObject player;
    public int speed = 5;
    public int turnspeed = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
        player.transform.Rotate(0, 0, 1000 * Time.deltaTime);
    player.transform.position += transform.forward * speed * Time.deltaTime;
    }
}
