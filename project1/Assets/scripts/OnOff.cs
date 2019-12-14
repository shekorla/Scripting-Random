using UnityEngine;

public class OnOff : MonoBehaviour
{
    public void Swap()
    {
        if (gameObject.active==true)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
