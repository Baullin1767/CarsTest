using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class BottonBouns : MonoBehaviour
{
    [SerializeField] private float scale = 1.08f;
    [SerializeField] private float duration = 0.6f;
    private RectTransform rectTransform;
    private Image image;
    
    private Tween _tween;

    private void Awake()
    {
        rectTransform =  GetComponent<RectTransform>();
    }

    private void OnEnable()
    {
        _tween = rectTransform
            .DOScale(scale, duration)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo)
            .SetLink(gameObject);
    }

    private void OnDisable()
    {
        _tween?.Kill();
        rectTransform.localScale = Vector3.one;
    }
}
