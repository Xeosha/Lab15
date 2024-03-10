namespace Lab15
{
    public class TeamHandlerEventArgs
    {
        public Team? Attacker { get; set; }
        public Team? Defender { get; set; }
        public string ActionDescription { get; set; }

        public TeamHandlerEventArgs(Team? attacker, Team? defender, string actionDescription)
        {
            Attacker = attacker;
            Defender = defender;
            ActionDescription = actionDescription;
        }

        public override string ToString() => ActionDescription;

    }

    public class Team
    {
        private int numSoldiers;

        public event EventHandler<TeamHandlerEventArgs>? TeamUpdated;
        public string Name { get; set; }
        
        public int NumSoldiers
        {
            get => numSoldiers;
            set
            {
                numSoldiers = Math.Max(0, value);
            }
        }

        public void OnTeamUpdated(object sender, TeamHandlerEventArgs e)
        {
            TeamUpdated?.Invoke(sender, e);
        }

        public Team(string name, int soldiers)
        {
            Name = name;
            NumSoldiers = soldiers;
        }

        public void IncreaseSoldiers()
        {
            int soldiersIncreased = new Random().Next(1, 30);

            NumSoldiers += soldiersIncreased;

            OnTeamUpdated(this, new TeamHandlerEventArgs(null, this, $"Войско команды: {Name} возросло на {soldiersIncreased}"));
        }

        public int Attack(Team otherTeam)
        {
            int soldiersKilled = new Random().Next(1, 80);
            otherTeam.NumSoldiers -= soldiersKilled;

            OnTeamUpdated(this, new TeamHandlerEventArgs(null, this, $"Команда {this.Name} атакует {otherTeam.Name} и наносит {soldiersKilled} урона"));

            return soldiersKilled;
        }

        public static string GetNameBattle(Team attacker, Team defender)
            => attacker.Name + " -> " + defender.Name;


    }
}