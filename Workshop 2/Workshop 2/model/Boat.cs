using System;

namespace Workshop_2.model
{
    public class Boat
    {
        public int ID { get; set; }

        public Boat(string type, string length)
        {
            Type = type;
            Length = length;
        }

        public string Type { get; set; }

        public string Length { get; set; }

        public override string ToString()
        {
            return $"Type: {Type}. Length: {Length} \n";
        }
    }
}