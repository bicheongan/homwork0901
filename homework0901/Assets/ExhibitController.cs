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

    private void Awake()
    {
        void CacheComponents() 
        {
            Renderer _selfRenderer= GetComponent<Renderer>();
            Debug.Log($"_selfRenderer 담음");
        }
        void InitAngle()
        {
            _angle = _startAngle;
            Debug.Log($"출력: {_angle}");
        }
    }
    private void OnEnable()
    {
        void ActivateVisual()
        {
            _selfRenderer
            _baseRenderer
        }
    }
    private void Start()
    {
        void BindSpot()
        {
            const string TAG_FAR = "SpotMark";
            GameObject farObject = GameObject.FindWithTag(TAG_FAR);
            _spotRenderer = farObject.GetComponent<Renderer>();
            Debug.Log($"태그로 찾은 것은{_spotRenderer}입니다.");
        }
    }
    private void Update()
    {
        void TurnExhibit()
        {
            _angle += _turnPerFrame;

        }
    }
    private void OnDisable()
    {
        void DeactivateVisual()
        {
            _selfRenderer
            _baseRenderer
        }
    }
    private void OnDestroy()
    {
        void ReportAngle()
        {

        }
        void HideSpot()
        {

        }
    }
}
