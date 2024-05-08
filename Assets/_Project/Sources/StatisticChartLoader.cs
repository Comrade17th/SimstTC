using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatisticChartLoader : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Sprite[] _sprites;

    private int _count => _sprites.Length;
    private int _current = 0;

    public void LoadNext()
    {
        _current = (_current + 1 + _count) % _count;
        LoadCurrent();
    }

    public void LoadPrevious()
    {
        _current = (_current - 1 + _count) % _count;
        LoadCurrent();
    }

    private void LoadCurrent()
    {
        if (_current < 0 || _current >= _sprites.Length)
        {
            Debug.Log($"sprite image out of range");
            return;
        }
        
        _image.sprite = _sprites[_current];
    }
}
