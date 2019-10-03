using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UITextControl : MonoBehaviour
{
    private Text textLable;
    public void UpdateText(intData data)
    {
        textLable.text = data.value.ToString();
    }
    void Awake()
    {
        textLable = GetComponent<Text>();
    }
}
