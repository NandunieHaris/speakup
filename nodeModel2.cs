using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider))]

public class nodeModel2 : MonoBehaviour
{
    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void animIdle()
    {
        anim.Play("Sitting");
        //anim.Play("Sitting");
    }

    public void animNod()
    {
        anim.Play("Clip1");
        
    }
    public void animclap()
    {
        anim.Play("SittingClap");
        
    }
}