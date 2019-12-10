using System.Collections;
using UnityEngine;

public class rapidFireWeapon : MonoBehaviour
{
    public float holdtime = .1f;
    public WaitForSeconds wFs;
    public gameAction gameActObj;
    
    private bool canRun=true;

    private void Awake()
    {
        wFs=new WaitForSeconds(holdtime);
    }

    private IEnumerator OnMouseDown()
    {
        canRun = true;
        while (canRun)
        {
            gameActObj.Raise();
            yield return wFs;
        }
    }

    private void OnMouseUp()
    {
        canRun = false;
    }
}
