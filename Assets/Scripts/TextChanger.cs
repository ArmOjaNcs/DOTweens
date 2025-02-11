using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    private void Start()
    {
        ChangeText();
    }

    private void ChangeText()
    {
        _text1.DOText("Changed text", 3f);
        _text2.DOText("Added text", 3f).SetRelative();
        _text3.DOText("Hacked text", 3f, true, ScrambleMode.All);
    }
}