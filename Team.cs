namespace Lab15
{
    public class Team
    {
        public string Name { get; set; }
        public int NumSoldiers { get; set; }

        public Team(string name, int soldiers)
        {
            Name = name;
            NumSoldiers = soldiers;
        }

        public void IncreaseSoldiers()
        {
            NumSoldiers += new Random().Next(1, 2);
        }

        public int Attack(Team otherTeam)
        {
            int soldiersKilled = new Random().Next(1, 80);
            otherTeam.NumSoldiers -= soldiersKilled;
            return soldiersKilled;
        }

        public static string GetNameBattle(Team attacker, Team defender)
            => attacker.Name + " -> " + defender.Name;


    }
}