using DG.Tweening;

public class SecondObject : TweenObject
{
    private protected override void Move()
    {
        transform.DORotate(EndPoint, Duration, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}