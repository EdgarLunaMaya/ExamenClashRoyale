using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldeano : Person
{
    public override void GetInfo()
    {
        base.GetInfo();
        id = 123;
        Debug.Log("aldeano ID: " + id);
    }

    // Start is called before the first frame update
    void Start()
    {
        GetInfo();
    }

}
