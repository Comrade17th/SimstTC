using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class StatisticWindow : Window
{
    [SerializeField] private StatisticChartLoader _chartLoader;
    [SerializeField] private Button _nextButton;
    [SerializeField] private Button _previousButton;

    private void Awake()
    {
        Assert.IsNotNull(_chartLoader);
        Assert.IsNotNull(_nextButton);
        Assert.IsNotNull(_previousButton);
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        _nextButton.onClick.AddListener(_chartLoader.LoadNext);
        _previousButton.onClick.AddListener(_chartLoader.LoadPrevious);
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        _nextButton.onClick.RemoveListener(_chartLoader.LoadNext);
        _previousButton.onClick.RemoveListener(_chartLoader.LoadPrevious);
    }
}
