using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Box_Background : UI_Box
{
    private Sprite Background;
    public Color BackgroundColor;
    // Start is called before the first frame update
    void Start()
    {
        Background = GetComponent<Sprite>();
        BackgroundColor = GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
