using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class UIimageController : MonoBehaviour
{
    private Image img;

    void Awake()
    {
        img = GetComponent<Image>();
    }

    public void updateImage(FloatData data)
    {
        img.fillAmount = data.value;
    }
}
