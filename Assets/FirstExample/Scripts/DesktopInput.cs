using System;
using UnityEngine;
using Zenject;

public class DesktopInput : IInput, ITickable
{
    public event Action<Vector3> ClickDown;
    public event Action<Vector3> ClickUp;
    public event Action<Vector3> Drag;

    private const int LeftMouseButton = 0;

    private bool _isSwiping;
    private Vector3 _previouMousePosition;

    public void Tick()
    {
        ProcessClickUp();
        ProcessClickDown();
        ProcessSwipe();
    }

    private void ProcessClickUp()
    {
        if (Input.GetMouseButtonUp(LeftMouseButton))
        {
            _isSwiping = false;
            ClickUp?.Invoke(Input.mousePosition);
        }
    }

    private void ProcessClickDown()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            _isSwiping = true;
            _previouMousePosition = Input.mousePosition;
            ClickDown?.Invoke(Input.mousePosition);
        }
    }

    private void ProcessSwipe()
    {
        if (_isSwiping == false)
            return;

        Vector3 currentMousePosition = Input.mousePosition;

        if(currentMousePosition != _previouMousePosition)
            Drag?.Invoke(currentMousePosition);

        _previouMousePosition = currentMousePosition;
    }
}
