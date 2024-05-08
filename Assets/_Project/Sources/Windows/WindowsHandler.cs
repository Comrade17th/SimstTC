using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class WindowsHandler : MonoBehaviour
{
	[SerializeField] private MainMenuWindow _mainMenuWindow;
	[SerializeField] private PaymentWindow _paymentWindow;
	[SerializeField] private Window _infoWindow;
	[SerializeField] private StatisticWindow _statisticWindow;

	private void Awake()
	{
		Assert.IsNotNull(_paymentWindow);
		Assert.IsNotNull(_mainMenuWindow);
		Assert.IsNotNull(_infoWindow);
		Assert.IsNotNull(_statisticWindow);
	}

	private void OnEnable()
	{
		_mainMenuWindow.PaymentButtonClicked += OnPaymentButtonClick;
		_mainMenuWindow.MapButtonClicked += OnMapButtonClick;
		_mainMenuWindow.InfoButtonClicked += OnInfoButtonClick;
		_mainMenuWindow.StatisticButtonClicked += OnStatistinButtonClick;
	}

	private void OnDisable()
	{
		_mainMenuWindow.PaymentButtonClicked -= OnPaymentButtonClick;
		_mainMenuWindow.MapButtonClicked -= OnMapButtonClick;
		_mainMenuWindow.InfoButtonClicked -= OnInfoButtonClick;
		_mainMenuWindow.StatisticButtonClicked -= OnStatistinButtonClick;
	}

	private void CloseAllWindows()
	{
		_paymentWindow.Close();
		_infoWindow.Close();
		_statisticWindow.Close();
	}

	private void OnPaymentButtonClick()
	{
		CloseAllWindows();
		_paymentWindow.Open();
	}

	private void OnMapButtonClick()
	{
		CloseAllWindows();
	}

	private void OnInfoButtonClick()
	{
		CloseAllWindows();
		_infoWindow.Open();
	}

	private void OnStatistinButtonClick()
	{
		CloseAllWindows();
		_statisticWindow.Open();
	}
}