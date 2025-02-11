using DG.Tweening;
using UnityEngine;

public class MultiAnimator : TweenObject
{
    [SerializeField] private Vector3 _scaleEndPoint;
    [SerializeField] private Vector3 _rotationEndPoint;

    private Sequence _sequence;

    private void Awake()
    {
        _sequence = DOTween.Sequence();
    }

    private protected override void Move()
    {
        _sequence.Append(transform.DOMove(EndPoint, Duration))
            .Insert(0f, transform.DORotate(_rotationEndPoint, Duration, RotateMode.Fast))
            .Insert(0f, transform.DOScale(_scaleEndPoint, Duration).From(transform.localScale))
            .SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}