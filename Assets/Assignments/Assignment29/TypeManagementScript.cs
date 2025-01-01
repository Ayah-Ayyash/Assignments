using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class TypeManagementScript : MonoBehaviour
{
    //4
    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal Sound");
        }
        public void Move()
        {
            Debug.Log("Animal moves");
        }
    }
    public class Cat : Animal, ICanFight
    {
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }
        public new void Move()
        {
            Debug.Log("Cat runs quickly");
        }
        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }
    }
    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }

    void Start()
    {


        //UP
        Cat cece = new Cat();
        Animal animal = cece;
        animal.MakeSound(); //Meow!
        animal.Move();      //Animal moves
        Animal animal1 = new Cat();
        //Down
        Cat soso = animal1 as Cat;
        soso?.MakeSound(); //Meow
        soso?.Move();      //Cat runs quickly




        List<ICanFight> fights = new List<ICanFight>();
        fights.Add(new Cat());
        fights.Add(new Warrior());
        foreach (var fight in fights)
        {
            fight.Attack();
            if (fight is Cat) { Debug.Log("The object is a Cat."); }
            else if (fight is Warrior) { Debug.Log("The object is a Warrior."); }
        }
    }

}


public interface ICanFight
{
    public void Attack();
}

