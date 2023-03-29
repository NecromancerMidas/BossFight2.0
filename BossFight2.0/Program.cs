using BossFight2._0.Characters;

namespace BossFight2._0

{

    class Program
    {

        static void Main(string[] args)
        {
            var hero = new Hero();
            var boss = new Boss();
            Character.Battle(hero, boss);
            


        }


    }


}
