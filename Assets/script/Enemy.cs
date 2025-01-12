using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CustomList{
public class Enemy 
{
    public string Name { get; set; }
    public int Health { get; set; }
    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }
    void Start()
    {
        // Name = "Default Name";
        // Health = 100;
    }
    //    public void Initialize(string name, int health)
    // {
    //     Name = name;
    //     Health = health;
    // }

    // Update is called once per frame
    void Update()
    {

    }
}

public class EnemyList
{
   private List<Enemy> enemies  = new List<Enemy>();// زي لما حطيتها من نوع رائد ليست

    public void AddEnemy(Enemy enemy) //براميتر من نوع انيمي
    {
        enemies.Add(enemy);
    }
    public void RemoveEnemy(Enemy enemy) //براميتر من نوع انيمي
    {
        enemies.Remove(enemy);
    }
    public List<Enemy> GetEnemies() //عشان اجيب قائمة الانيميز كلها
    {
        return enemies;
    }






}

}