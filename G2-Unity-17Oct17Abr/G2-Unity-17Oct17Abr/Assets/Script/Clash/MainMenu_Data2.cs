using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public struct CR_Data
{
    public string Level;
    public string Gold;
    public string Emeralds;
    public string User;
    public string Clan;
}

public class MainMenu_Data2 : MonoBehaviour
{
    [Header("MAIN MENU CONFIG")]
   public CR_Data data;
    [Header("MAIN MENU UI")]

    public TMP_Text Level;
    public TMP_Text Gold;
    public TMP_Text Emeralds;
    public TMP_Text User;
    public TMP_Text Clan;


    void Start()
    {
        Level.text = data.Level.ToString();
        Gold.text = data.Gold.ToString();
        Emeralds.text = data.Emeralds.ToString();
        User.text = data.User;
        Clan.text = data.Clan;
    }

    // Update is called once per frame
    void Update()
    {
        Level.text = data.Level.ToString();
        Gold.text = data.Gold.ToString();
        Emeralds.text = data.Emeralds.ToString();
        User.text = data.User;
        Clan.text = data.Clan;
    }
}
