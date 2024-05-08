using System;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class MainMenuWindow : Window
{
    [SerializeField] private Button _paymentButton;
    [SerializeField] private Button _mapButton;
    [SerializeField] private Button _infoButton;
    [SerializeField] private Button _statisticButton;

    public event Action PaymentButtonClicked;
    public event Action MapButtonClicked;
    public event Action InfoButtonClicked;

    public event Action StatisticButtonClicked;
    
    private void Awake()
    {
        Assert.IsNotNull(_paymentButton);
        Assert.IsNotNull(_mapButton);
        Assert.IsNotNull(_infoButton);
        Assert.IsNotNull(_statisticButton);
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        
        _paymentButton.onClick.AddListener(OnPaymentButtonClick);
        _mapButton.onClick.AddListener(OnMapButtonClick);
        _infoButton.onClick.AddListener(OnInfoButtonClick);
        _statisticButton.onClick.AddListener(OnStatisticButtonClick);
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        
        _paymentButton.onClick.RemoveListener(OnPaymentButtonClick);
        _mapButton.onClick.RemoveListener(OnMapButtonClick);
        _infoButton.onClick.RemoveListener(OnInfoButtonClick);
        _statisticButton.onClick.RemoveListener(OnStatisticButtonClick);
    }

    private void OnPaymentButtonClick()
    {
        PaymentButtonClicked?.Invoke();
    }

    private void OnMapButtonClick()
    {
        MapButtonClicked?.Invoke();
    }

    private void OnInfoButtonClick()
    {
        InfoButtonClicked?.Invoke();
    }

    private void OnStatisticButtonClick()
    {
        StatisticButtonClicked?.Invoke();
    }
}
