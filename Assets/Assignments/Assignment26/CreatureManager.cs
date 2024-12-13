using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        Kangaroo kangaroo = new Kangaroo();
        Duck duck = new Duck();

        void Start()
        {
            List<Creature> creatures = new List<Creature>
            {
                 kangaroo,
                  duck
            };
            List<IRunnable> runnables = new List<IRunnable>();
            List<IJumpable> jumpables = new List<IJumpable>();
            List<ISwimmable> swimmables = new List<ISwimmable>();

            runnables.Add(kangaroo);
            jumpables.Add(kangaroo);
            runnables.Add(duck);
            swimmables.Add(duck);

            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }
            foreach (IRunnable runnable in runnables)
            {
                runnable.Run();
            }
            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }
            foreach (ISwimmable swimmable in swimmables)
            {
                swimmable.Swim();
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}