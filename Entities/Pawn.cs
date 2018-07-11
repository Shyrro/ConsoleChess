using System;
using Enums;

namespace Entities
{
    abstract public class Pawn {
        
        public Pawn(string id, Position position, Color color){
            this.Id = id;
            this.Position = position;
            this.Color = color;
        }

        public string Id {get;set;}
        public Position Position {get;set;}
        public Color Color {get;set;}

        abstract public void move(Position start, Position end);

    }

}