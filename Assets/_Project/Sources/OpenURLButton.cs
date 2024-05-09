using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class OpenURLButton : MonoBehaviour
{
    [SerializeField] private string _url;

    [SerializeField] private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        button.onClick.AddListener(OpenUrl);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(OpenUrl);
    }

    private void OpenUrl()
    {
        Application.OpenURL(_url);
    }
}
