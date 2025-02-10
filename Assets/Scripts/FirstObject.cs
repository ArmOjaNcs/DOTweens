using DG.Tweening;

public class FirstObject : TweenObject
{
    private protected override void Move()
    {
        transform.DOMove(EndPoint, Duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}