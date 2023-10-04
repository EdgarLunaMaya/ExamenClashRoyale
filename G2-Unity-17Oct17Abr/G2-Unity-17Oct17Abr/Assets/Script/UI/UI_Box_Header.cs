using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Box_Header : UI_Box_Background
{
    private Sprite Header;
    public Color HeaderColor;
    // Start is called before the first frame update
    void Start()
    {
        Header = GetComponent<Sprite>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
