using DG.Tweening;

public class Mover : TweenObject
{
    private protected override void Move()
    {
        transform.DOMove(EndPoint, Duration).SetLoops(-1, LoopType).SetEase(Ease.Linear);
    }
}