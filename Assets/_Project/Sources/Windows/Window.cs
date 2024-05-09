using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class Window : MonoBehaviour
{
    [SerializeField] protected Button _nextWindowButton;
    [SerializeField] protected Button _closeButton;
    [SerializeField] protected Button _mainMenuButton;
    
    public event Action NextWindowButtonClicked;
    public event Action MainMenuwButtonClicked;
    
    private void Awake()
    {
        // Assert.IsNotNull(_nextWindowButton);
        // Assert.IsNotNull(_closeButton);
    }

    protected virtual void OnEnable()
    {
        if (_mainMenuButton != null)
            _mainMenuButton.onClick.AddListener(OnMainMenuButtonClick);
        
        if (_nextWindowButton != null)
            _nextWindowButton.onClick.AddListener(OnNextWindowButtonClick);
        
        if (_closeButton != null)
            _closeButton.onClick.AddListener(Close);
    }

    protected virtual void OnDisable()
    {
        if (_mainMenuButton != null)
            _mainMenuButton.onClick.AddListener(OnMainMenuButtonClick);
        
        if (_nextWindowButton != null)
            _nextWindowButton.onClick.RemoveListener(OnNextWindowButtonClick);
        
        if (_closeButton != null) 
            _closeButton.onClick.RemoveListener(Close);
    }

    public virtual void Close()
    {
        gameObject.SetActive(false);
    }

    public virtual void Open()
    {
        gameObject.SetActive(true);
    }

    protected virtual void OnNextWindowButtonClick()
    {
        NextWindowButtonClicked?.Invoke();
    }

    protected virtual void OnMainMenuButtonClick()
    {
        MainMenuwButtonClicked?.Invoke();
    }
}
