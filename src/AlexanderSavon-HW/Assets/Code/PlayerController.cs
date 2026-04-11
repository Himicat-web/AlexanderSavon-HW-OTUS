using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
public int hp = 100;
 public void Hp()
 {
 
  if (hp <= 0)
  {
   Debug.Log("Death");
  }
 }
 
 public void AddHealth(int amount)
 { hp += amount; }
}
