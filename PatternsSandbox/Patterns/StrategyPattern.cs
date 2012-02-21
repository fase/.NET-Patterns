using System;

namespace PatternsSandbox.Patterns
{
    class StrategyPattern : IPattern
    {
        private Character _warrior;

        public void RunExample()
        {
            _warrior = new Character("Knight") { Weapon = new Sword() };
            _warrior.Attack();

            _warrior = new Character("Ninja") { Weapon = new Nunchuck() };
            _warrior.Attack();

            _warrior = new Character("Navy Seal") { Weapon = new MachineGun() };
            _warrior.Attack();
            //_warrior.Weapon = new Nunchuck();
            //_warrior.Attack();
            //_warrior.Weapon = new Sword();
            //_warrior.Attack();
        }
    }

    class Character
    {
        private readonly string _name;

        public IWeapon Weapon { get; set; }

        public Character(string name)
        {
            _name = name;
        }

        public void Attack()
        {
            Console.WriteLine("{0} {1}", _name, Weapon.UseWeapon());
        }
    }

    interface IWeapon
    {
        string UseWeapon();
    }

    class Sword : IWeapon
    {
        public string UseWeapon()
        {
            return "swings his sword.";
        }
    }

    class Nunchuck : IWeapon
    {
        public string UseWeapon()
        {
            return "flails his nunchucks.";
        }
    }

    class MachineGun : IWeapon
    {
        public string UseWeapon()
        {
            return "shoots his machine gun.";
        }
    }
}
