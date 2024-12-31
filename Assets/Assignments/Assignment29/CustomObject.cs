using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
namespace Assignment29
{

    public class CustomObject
    {
        public int ID { get; private set; }
        public string Name { get; private set; }


        public CustomObject(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Object [ID: {ID}, Name: {Name}]";
        }
    }
    /*
            public static bool operator ==(CustomObject p1, CustomObject p2)
            {
                if (!p1.Equals(null) && !p2.Equals(null))
                {
                    if (p1.Name.Equals(p2.Name)) return true;
                }
                return false;
            }



            public static bool operator !=(CustomObject p1, CustomObject p2)
            {
                if (!p1.Equals(null) && !p2.Equals(null))
                {
                    if (!p1.Name.Equals(p2.Name)) return true;
                }
                return false;
            }


            // public static bool operator ==(CustomObject o, CustomObject b)
            // {
            //     if (ReferenceEquals(o, b)) return true;
            //     if (o is null || b is null) return false;
            //     return o.ID == b.ID && o.Name == b.Name;
            // }


            // public static bool operator !=(CustomObject o, CustomObject b)
            // {
            //     return !(o == b);
            // }
            // public override int GetHashCode()
            // {
            //     return ID.GetHashCode();
            // }

            // Update is called once per frame
            void Update()
            {

            }

    */
}
