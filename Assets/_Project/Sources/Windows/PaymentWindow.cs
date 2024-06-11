using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaymentWindow : Window
{
    private void OpenPaymentUrl()
    {
        Application.OpenURL($"https://online.vtb.ru/login?utm_source=yandex&utm_medium=cpc&utm_campaign=mgcom-mobile_yd_vtbo_web_brand_search%7C107888083&utm_content=cid%7C107888083%7Cgid%7C5409301742%7Caid%7C15884501393%7C50735662038_50735662038%7Ccrt_0%7Cdvc%7Cdesktop%7Creg%7CКазань&utm_term=---autotargeting&yclid=1967274824980234239");
    }

    protected override void OnNextWindowButtonClick()
    {
        base.OnNextWindowButtonClick();
        OpenPaymentUrl();
        Close();
    }
}
