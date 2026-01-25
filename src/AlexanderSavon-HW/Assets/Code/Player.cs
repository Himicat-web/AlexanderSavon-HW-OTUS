using UnityEngine;
using Random = UnityEngine.Random;

namespace DamageСalculation
{
   
    
    public class Player : MonoBehaviour
    {
        public bool isEnemy;
        public int hp = 100;
        private bool isDeath;
        private MeshRenderer meshRenderer;

        private void Start()
        {
            
            if (hp <= 0)
            {
                isDeath = true;
            }
            
            meshRenderer = GetComponent<MeshRenderer>();
            SetColor();

           void SetColor()
            {
                if (isEnemy)
                    meshRenderer.material.color = Color.red;
                else
                    meshRenderer.material.color = Color.blue;
            }
        }
    }
}