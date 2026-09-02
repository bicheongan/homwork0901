using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitController : MonoBehaviour
{
    [SerializeField] private Renderer _baseRenderer;
    [SerializeField] private float _turnPerFrame = 0.5f;
    [SerializeField] private float _startAngle = 30;

    [SerializeField] private Renderer _selfRenderer;
    [SerializeField] private Renderer _spotRenderer;
    [SerializeField] private float _angle;

    const string TAG_FAR = "Spot";

    private void Awake()
    {
        CacheComponents();
        InitAngle();
    }

    private void OnEnable()
    {
        ActivateVisual();
    }

    private void Start()
    {
        BindSpot();
    }

    private void Update()
    {
        TurnExhibit();
    }

    private void OnDisable()
    {
        DeactivateVisual();
    }

    private void OnDestroy()
    {
        ReportAngle();
        HideSpot();
    }

    private void CacheComponents()
    {
        _selfRenderer = GetComponent<Renderer>();
        Debug.Log($"출력: _selfRenderer 담음");
        //Renderer a = GetComponent<Renderer>();
        //Debug.Log($"출력: a 담음");
    }

    private void InitAngle()
    {
        _angle = _startAngle;
        Debug.Log($"_angle: {_angle}");
    }

    private void ActivateVisual()
    {
        _selfRenderer.enabled = true;
        _baseRenderer.enabled = true;

        Debug.Log($"ActivateVisual: 켜짐");
    }

    private void BindSpot()
    {
        GameObject farObject = GameObject.FindWithTag(TAG_FAR);
        GameObject.FindWithTag("Spot");
        Debug.Log($"출력: 태그로 찾은 것은 {farObject}입니다.");
    }

    private void TurnExhibit()
    {
        _angle += _turnPerFrame;
    }

    private void DeactivateVisual()
    {
        _selfRenderer.enabled = false;
        _baseRenderer.enabled = false;

        Debug.Log($"DeactivateVisual: 꺼짐");
    }

    private void ReportAngle()
    {
        Debug.Log($"ReportAngle: 쌓인 각도: {_angle}");
    }

    private void HideSpot()
    {
        _spotRenderer = GetComponent<Renderer>();
        _spotRenderer.enabled = false;

        Debug.Log($"HideSpot: 표식 꺼짐");
    }
}
