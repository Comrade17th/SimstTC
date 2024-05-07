using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class WindowsHandler : MonoBehaviour
{
	[SerializeField] private PaymentWindow _paymentWindow;
	// [SerializeField] private Window _testsListWindow;
	// [SerializeField] private TestMenu _testAdzies;
	// [SerializeField] private ResultMenu _resultAdziesMenu;

	private void Awake()
	{
		Assert.IsNotNull(_paymentWindow);
		// Assert.IsNotNull(_testsListWindow);
		// Assert.IsNotNull(_testAdzies);
		// Assert.IsNotNull(_resultAdziesMenu);
	}

	private void OnEnable()
	{
		// _testsListWindow.NextWindowButtonClicked += AdziesButtonClick;
		// _testAdzies.ShowResultsButtonClicked += AdziesResultsButtonClick;
		// _resultAdziesMenu.NextWindowButtonClicked += ToMainMenu;
	}

	private void OnDisable()
	{
		// _testsListWindow.NextWindowButtonClicked -= AdziesButtonClick;
		// _testAdzies.ShowResultsButtonClicked -= AdziesResultsButtonClick;
		// _resultAdziesMenu.NextWindowButtonClicked -= ToMainMenu;
	}

	private void SignInButtonClick()
	{
		// _testsListWindow.Open();
	}

	private void AdziesButtonClick()
	{
		// _testsListWindow.Close();
		// _testAdzies.Open();
	}

	private void AdziesResultsButtonClick()
	{
		// _testAdzies.Close();
		// _resultAdziesMenu.Open();
	}

	private void ToMainMenu()
	{
		Debug.Log($"To main menu");
		// _testAdzies.Close();
		// _resultAdziesMenu.Close();
        
		// _testsListWindow.Open();
	}
}