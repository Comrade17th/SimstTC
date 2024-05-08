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

	private void Awake()
	{
		Assert.IsNotNull(_paymentWindow);
		Assert.IsNotNull(_mainMenuWindow);
		Assert.IsNotNull(_infoWindow);
	}

	private void OnEnable()
	{
		_mainMenuWindow.PaymentButtonClicked += OnPaymentButtonClick;
		_mainMenuWindow.MapButtonClicked += OnMapButtonClick;
		_mainMenuWindow.InfoButtonClicked += OnInfoButtonClick;
	}

	private void OnDisable()
	{
		_mainMenuWindow.PaymentButtonClicked -= OnPaymentButtonClick;
		_mainMenuWindow.MapButtonClicked -= OnMapButtonClick;
		_mainMenuWindow.InfoButtonClicked -= OnInfoButtonClick;
	}

	private void CloseAllWindows()
	{
		_paymentWindow.Close();
		_infoWindow.Close();
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
}