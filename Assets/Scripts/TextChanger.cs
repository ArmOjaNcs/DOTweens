using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    private Sequence _sequence;

    private void Awake()
    {
        _sequence = DOTween.Sequence();
    }

    private void Start()
    {
        ChangeText();
    }

    private void ChangeText()
    {
        _sequence.Append(_text.DOText("Changed text", 3f))
            .Append(_text.DOText("Added text", 3f).SetRelative())
            .Append(_text.DOText("Hacked text", 3f, true, ScrambleMode.All));
    }
}