using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UITextControl : MonoBehaviour
{
    public UnityEvent startEvent;
    private Text textLable;
    public void UpdateText(intData data)
    {
        textLable.text = data.value.ToString();
    }
    void Start()
    {
        textLable = GetComponent<Text>();
        startEvent.Invoke();
    }
}
