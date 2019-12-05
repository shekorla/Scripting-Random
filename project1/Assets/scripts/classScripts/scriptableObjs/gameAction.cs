
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]
public class gameAction : ScriptableObject
{
   public UnityAction action;

   public void Raise()
   {
      action?.Invoke();
   }
}
