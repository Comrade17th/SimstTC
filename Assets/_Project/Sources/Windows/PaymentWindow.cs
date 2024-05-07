using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaymentWindow : Window
{
    public void OpenPaymentUrl()
    {
        Application.OpenURL($"https://online.sberbank.ru/CSAFront/index.do");
    }

    protected override void OnNextWindowButtonClick()
    {
        base.OnNextWindowButtonClick();
        OpenPaymentUrl();
        Close();
    }
}
