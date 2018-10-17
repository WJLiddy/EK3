using UnityEngine;
using System.Collections;

public class Camera2D : MonoBehaviour
{
    private int pixelsPerUnit = 50;
    private Camera _camera;
    protected new Camera camera { get { if (_camera == null) { _camera = GetComponent<Camera>(); } return _camera; } }

    protected virtual void Awake()
    {
        Calculate();
    }

    protected virtual void Update()
    {
        Calculate();
        if (Common.knight != null)
        {
            camera.transform.localPosition = new Vector3(Common.knight.transform.localPosition.x, Common.knight.transform.localPosition.y, -10);
        }
    }

    protected virtual void LateUpdate()
    {
        Calculate();
    }

    private void Calculate()
    {
        int zoom = (int)Mathf.Max(1f, (Screen.height / 240f));
        camera.orthographicSize = ((Screen.height / 2f) / (float)pixelsPerUnit) / (float)zoom;
    }
}