using DG.Tweening;

public class ThirdObject : TweenObject
{
    private protected override void Move()
    {
        transform.DOScale(EndPoint, Duration).From(transform.localScale)
            .SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}