using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider))]
public class nodModel : MonoBehaviour
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
        anim.Play("sitting");
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
