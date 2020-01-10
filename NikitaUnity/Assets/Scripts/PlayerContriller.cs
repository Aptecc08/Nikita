using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerContriller : MonoBehaviour
{
    public Rigidbody player;
    public int speed = 5;
    public bool right;
    public int x;
    public int y;
    public int z;
    public int napravlenie;
    public GameObject Trassa;


    // Start is called before the first frame update
    void Start()
    {
      right = true;
        x = 3;
        y = -2;
        z = -6;
        InvokeRepeating("mapx", 1, 1);
        InvokeRepeating("acceleration", 10, 5);


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
        if (player.transform.position.y < -1.5) 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }

    public void click()
    {
        if (right == true)
            right = false;
        else
            right = true;
    }

    public void mapx()
    {
        Instantiate(Trassa, new Vector3(x, -2, z), Quaternion.identity);
        napravlenie = Random.Range(1, 3);
        if (napravlenie < 2)
            x++;
        else
            z++;
    }
    public void acceleration()
    {
        speed = speed + 5;
    }




}
