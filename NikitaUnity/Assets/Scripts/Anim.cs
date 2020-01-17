using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    public Animation anim;
    public GameObject empty;
    public GameObject Trassa;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnCollisionEnter(Collision empty)
    {
        ContactPoint contact = empty.contacts[0];
        anim.Play("");
        Destroy(Trassa);
    }
}
