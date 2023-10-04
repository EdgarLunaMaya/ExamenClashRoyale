using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Box : MonoBehaviour
{
    protected UI_Box_Background BoxBackgrund;
    protected UI_Box_Header BoxHeader;
    protected UI_Box_Header_Title BoxHeaderTitle;
    protected UI_Box_Background_Container_Content BoxContent;

    public string title = "";
    public string content = "";
    public bool hasCloseBtn = true;

    // Start is called before the first frame update
    void Start()
    {
        BoxBackgrund = transform.GetChild(0).GetComponent<UI_Box_Background>();
        BoxHeader = transform.GetChild(0).transform.GetChild(0).GetComponent<UI_Box_Header>();
        BoxHeaderTitle = transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).GetComponent<UI_Box_Header_Title>();
        BoxContent = transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).GetComponent<UI_Box_Background_Container_Content>();
        // Set Information
        BoxHeaderTitle.Title.text = title;
        BoxContent.content.text = content;

        if (hasCloseBtn)
        {
            transform.GetChild(0).transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(hasCloseBtn);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

