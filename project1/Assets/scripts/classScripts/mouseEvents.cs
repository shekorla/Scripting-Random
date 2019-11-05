using UnityEngine;
using UnityEngine.Events;

public class mouseEvents : MonoBehaviour
{
    public UnityEvent mouseEvent;
    private Camera cam;
    public Vector3Data data;

    private void Start()
    {
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hit))
        {
            data.value = hit.point;
        }
        //mouseEvent.Invoke();
    }
}
