using DG.Tweening;

public class Rotator : TweenObject
{
    private protected override void Move()
    {
        transform.DORotate(EndPoint, Duration, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType).SetEase(Ease.Linear);
    }
}