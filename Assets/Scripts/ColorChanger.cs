using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private List<Color> _colors;
    [SerializeField] private float _duration;

    private int _indexOfColor;

    private void Start()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        _indexOfColor = Random.Range(0, _colors.Count);
        _renderer.material.DOColor(_colors[_indexOfColor], _duration).OnComplete(() => ChangeColor());
    }
}