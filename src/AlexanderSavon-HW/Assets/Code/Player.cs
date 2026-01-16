namespace DamageСalculation
{

    using UnityEngine;
    using Random = UnityEngine.Random;

    public class Player : MonoBehaviour
    {
        public float baseDamage = 55.0f; //добавил в инспектор что бы можно было регулировать

      private float CritDamage;

        void Start()
        {
            int Multiplier = Random.Range(2, 5); // рандом для множителя урона
            int CritChance = Random.Range(1, 100); // рандом для шанса крит удара 

            if (CritChance >= 70) // сделал 30 процентов
            {
                CritDamage = (baseDamage * Multiplier);
                Debug.Log("Критический урон! Нанесено: " + CritDamage);
            }

            else
            {
                Debug.Log("Нанесено урона: " + baseDamage);
            }
        }
    }
}