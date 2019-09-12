using UnityEngine;
using UnityEngine.Events;

public class catClass : MonoBehaviour
{
   public UnityEvent catActs;

   private void OnMouseDown()
   {
      catActs.Invoke();
   }
}
