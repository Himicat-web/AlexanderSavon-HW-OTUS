using UnityEngine;

public class GameManager : MonoBehaviour
{
 [SerializeField] public CubeObstacle Heal_Cube;
 [SerializeField] private Transform startPos;

 private void Start()
 {
  Create();
 }
 private void Create()

 {
   Vector2 size = new(2, 10);
   for (int i = 0; i < size.x; ++i)
   {
    for (int j = 0; j < size.y; ++j)
    {
     float x = startPos.position.x + i;
     float z = startPos.position.z + j;
     Vector3 pos = startPos.position + new Vector3(x, 0.25f, z);
     Instantiate(Heal_Cube, pos, Quaternion.identity);
    }
   }
  }
 }

