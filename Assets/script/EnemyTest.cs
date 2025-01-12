using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CustomList
{
    public class EnemyTest : MonoBehaviour
    {
       private EnemyList enemyList;//لازم اسوي هيك

        // EnemyList.AddEnemies= (new EnemyList("ayah" , 16));
        // EnemyList.AddEnemy(new EnemyList("Goblin", 100));



        void Start()
        {

            enemyList=new EnemyList(); //instace
            enemyList.AddEnemy(new Enemy("Goblin", 100));
            enemyList.AddEnemy(new Enemy("Goblin", 100));
            
            foreach (var enemy in enemyList.GetEnemies())
            {
                Debug.Log($"EnemyName ={enemy.Name} + EnemyHealth = {enemy.Health}");
            }


        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}