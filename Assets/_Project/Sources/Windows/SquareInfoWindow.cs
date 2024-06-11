using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class SquareInfoWindow : Window
{
    [SerializeField] private Text _organizationName;
    [SerializeField] private Text _square;
    [SerializeField] private Text _price;

    private void Awake()
    {
        Assert.IsNotNull(_organizationName);
        Assert.IsNotNull(_square);
        Assert.IsNotNull(_price);
    }

    public void ChangeInfo(string text)
    {
        string[] elements = text.Split('|');
        
        if (elements.Length == 3)
        {
            _organizationName.text = elements[0];
            _square.text = elements[1];
            _price.text = elements[2];

        }
        else
        {
            Debug.Log($"SquareInfoWindow, low count of input");
        }
    }
}
