using System.Windows.Forms;
using Classes;

namespace Lab15
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, Team> teamsDict;
        private readonly Dictionary<string, Thread> threadsDict;
        private bool flagWinner;

        public Form1()
        {
            InitializeComponent();

            teamsDict = new();
            threadsDict = new();
            flagWinner = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PriorityThreadComboBox.Items.Add(ThreadPriority.Lowest);
            PriorityThreadComboBox.Items.Add(ThreadPriority.BelowNormal);
            PriorityThreadComboBox.Items.Add(ThreadPriority.Normal);
            PriorityThreadComboBox.Items.Add(ThreadPriority.AboveNormal);
            PriorityThreadComboBox.Items.Add(ThreadPriority.Highest);
        }


        // функци€ сражени€, которую и будем запускать в разных потоках.
        private void Battle(Team teamAttack, Team teamDefend)
        {
            while (teamAttack.NumSoldiers > 0 && teamDefend.NumSoldiers > 0 && !flagWinner)
            {
                lock (this)
                {
                    teamAttack.IncreaseSoldiers();
                    var damage = teamDefend.Attack(teamDefend);

                    Invoke(() => { UpdateUIResult(teamAttack, teamDefend, damage); UpdateUIResult2(); });
                }

                Thread.Sleep(1000);
            }

            flagWinner = true;


            MessageBox.Show("¬ыиграла команда: " + teamAttack.Name + " !!!");
        }

        // обновл€ет через Invoke() в главном потоке UI второго лист бокса
        private void UpdateUIResult2()
        {
            ResultListBox2.Items.Clear();
            foreach (var value in teamsDict.Values)
            {
                ResultListBox2.Items.Add("Team: " + value.Name + " - soldiers: " + value.NumSoldiers);
            }
        }

        private void UpdateUIResult(Team attackingTeam, Team defendingTeam, int damage)
        {
            ResultListBox.Items.Add(attackingTeam.Name + " атакует " + defendingTeam.Name + " и наносит: " + damage + " урона");
        }



        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            var nameTeam = NameTeamText.Text;
            int soldiersNum;

            var flag = int.TryParse(CountSoldiersText.Text, out soldiersNum);

            if (flag && soldiersNum > 0 && nameTeam != "")
            {
                if (teamsDict.ContainsKey(nameTeam))
                {
                    MessageBox.Show("“ака€ команда уже существует", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var team = new Team(nameTeam, soldiersNum);
                    teamsDict.Add(team.Name, team);

                    // ƒобавл€ем в панели ниже
                    TeamAttackComboBox.Items.Add(nameTeam);
                    TeamDefendComboxBox.Items.Add(nameTeam);
                }
            }
            else
            {
                MessageBox.Show("Ќеверно заданный формат", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateThreadButton_Click(object sender, EventArgs e)
        {
            if (TeamAttackComboBox.SelectedIndex == -1 || TeamDefendComboxBox.SelectedIndex == -1)
                return;

            var teamAttacker = teamsDict[TeamAttackComboBox.Text];
            var teamDefender = teamsDict[TeamDefendComboxBox.Text];


            // заполн€ем атрибуты класса потока
            var battleThread = new Thread(() => Battle(teamAttacker, teamDefender));
            battleThread.Name = Team.GetNameBattle(teamAttacker, teamDefender);

            if (threadsDict.ContainsKey(battleThread.Name))
            {
                MessageBox.Show("“акой поток уже существует.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                threadsDict.Add(battleThread.Name, battleThread);
                
                // ƒобавл€ем в панель ниже
                ThreadComboBox.Items.Add(battleThread.Name);
            }

        }

        private void SavePriorityThreadButton_Click(object sender, EventArgs e)
        {
            if (ThreadComboBox.SelectedIndex == -1 || PriorityThreadComboBox.SelectedIndex == -1)
                return;

            var thread = threadsDict[ThreadComboBox.Text];

            if (Enum.TryParse(PriorityThreadComboBox.Text, out ThreadPriority threadPriority))
            {
                thread.Priority = threadPriority;

            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            foreach (var thread in threadsDict.Values)
            {
                if (!thread.IsAlive) // чтобы можно было добавл€ть новые "сражени€" (не запущеннные потоки)
                {
                    thread.IsBackground = true; // потоки в фоновом режиме - завершаетс€ основной. завершаетс€ и он.
                    thread.Start();
                }

            }
        }

    }


}
