using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MoveToCentre : MonoBehaviour
{
    [SerializeField] private float duration = 0.6f;
    private Vector3 pos;
    private RectTransform rectTransform;
    
    private Tween _tween;

    private void Awake()
    {
        rectTransform =  GetComponent<RectTransform>(); 
        pos = rectTransform.localPosition;
    }

    private void OnEnable()
    {
        _tween = rectTransform
            .DOMoveY(Screen.height / 2, duration)
            .SetEase(Ease.OutBack);
    }

    private void OnDisable()
    {
        _tween?.Kill();
        rectTransform.localPosition = pos;
    }
}
