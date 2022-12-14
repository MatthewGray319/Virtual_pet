using System;
namespace template_csharp_virtual_pet
{
    public abstract class GamePets
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }
        public int Hunger { get; set; }

        public abstract string ToStringRepresentation();
        public abstract void Play();
        public abstract void SeeDoctor();
        public abstract void Tick();
        public abstract void Feed();     
        
    }
}

