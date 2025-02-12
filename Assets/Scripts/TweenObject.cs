using DG.Tweening;
using UnityEngine;

public abstract class TweenObject : MonoBehaviour
{
    [SerializeField] private protected Vector3 EndPoint;
    [SerializeField] private protected float Duration;
    [SerializeField] private protected LoopType LoopType;

    private void Start()
    {
        Move();
    }

    private protected abstract void Move();
}