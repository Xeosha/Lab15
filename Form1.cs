using System.Windows.Forms;

namespace Lab15
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, Team> teamsDict;
        private readonly Dictionary<string, Thread> threadsDict;
        private bool gameRunning;

        public Form1()
        {
            InitializeComponent();

            teamsDict = new();
            threadsDict = new();
            gameRunning = false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PriorityThreadComboBox.Items.AddRange(Enum.GetValues(typeof(ThreadPriority)).Cast<object>().ToArray());
        }


        // ������� ��������, ������� � ����� ��������� � ������ �������.
        private void Battle(Team teamAttack, Team teamDefend)
        {
            while (teamAttack.NumSoldiers > 0 && teamDefend.NumSoldiers > 0)
            {
                lock (this)
                {
                    if (!gameRunning)
                        break;

                    teamDefend.IncreaseSoldiers();
                    teamAttack.Attack(teamDefend);
                }

                Thread.Sleep(1000);

            }
        }

        private void Restart()
        {
            teamsDict.Clear();
            threadsDict.Clear();
            ClearComboBoxes();
        }

        private void ClearComboBoxes()
        {
            TeamAttackComboBox.Items.Clear();
            TeamDefendComboxBox.Items.Clear();
            ThreadComboBox.Items.Clear();
        }

        private void ClearListBoxes()
        {
            ResultListBox.Items.Clear();
            ResultListBox2.Items.Clear();
        }

        private void UpdateUIResult2()
        {
            ResultListBox2.Items.Clear();
            foreach (var value in teamsDict.Values)
                ResultListBox2.Items.Add("Team: " + value.Name + " - soldiers: " + value.NumSoldiers);
        }

        private void UpdateUIResult1(string row)
        {
            ResultListBox.Items.Add(row);
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
                    MessageBox.Show("����� ������� ��� ����������", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var team = new Team(nameTeam, soldiersNum);
                    teamsDict.Add(team.Name, team);

                    // ��������� � ������ ����
                    TeamAttackComboBox.Items.Add(nameTeam);
                    TeamDefendComboxBox.Items.Add(nameTeam);

                    team.TeamUpdated += Team_OnTeamUpdated;

                    MessageBox.Show("�������� �������� ������� ��� ���������: " + nameTeam, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    NameTeamText.Text = null;
                    CountSoldiersText.Text = null;
                }
            }
            else
            {
                MessageBox.Show("������� �������� ������", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Team_OnTeamUpdated(object sender, TeamHandlerEventArgs e)
        {
            Invoke(() => UpdateUIResult2());
            Invoke(() => UpdateUIResult1(e.ActionDescription));

            var aliveTeams = teamsDict.Values.ToList().FindAll(team => team.NumSoldiers > 0);
            if (aliveTeams.Count == 1)
            {
                gameRunning = false;
                Invoke(() =>
                {
                    MessageBox.Show($"{aliveTeams[0].Name} wins!");
                    Restart();
                });
            }
        }

        private void CreateThreadButton_Click(object sender, EventArgs e)
        {
            // ���� �� �������, �������.
            if (TeamAttackComboBox.SelectedIndex == -1 || TeamDefendComboxBox.SelectedIndex == -1)
                return;

            var teamAttacker = teamsDict[TeamAttackComboBox.Text];
            var teamDefender = teamsDict[TeamDefendComboxBox.Text];

            // ��������� �������� ������ ������
            var battleThread = new Thread(() => Battle(teamAttacker, teamDefender));
            battleThread.Name = Team.GetNameBattle(teamAttacker, teamDefender);

            if (threadsDict.ContainsKey(battleThread.Name))
            {
                MessageBox.Show("����� ����� ��� ����������.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ��������� � ������� �������
                threadsDict.Add(battleThread.Name, battleThread);

                // ��������� � ������ ����
                ThreadComboBox.Items.Add(battleThread.Name);

                MessageBox.Show("����� ������ ��� ���������: " + battleThread.Name, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // �������� ��������� ������������� ����
                TeamAttackComboBox.SelectedIndex = -1;
                TeamDefendComboxBox.SelectedIndex = -1;
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

                ThreadComboBox.SelectedIndex = -1;
                PriorityThreadComboBox.SelectedIndex = -1;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if(teamsDict.Count < 2) {
                MessageBox.Show("�����, ��� �� ����������?");
            }
            //if (!gameRunning)
            gameRunning = true;
            StartGame();

        }

        private void StartGame()
        {
            foreach (var thread in threadsDict.Values)
            {
                if (!thread.IsAlive) // ����� ����� ���� ��������� ����� "��������" (�� ����������� ������)
                {
                    thread.IsBackground = true; // ������ � ������� ������ - ����������� ��������. ����������� � ��.
                    thread.Start();
                }
            }
        }

        private void ClearListBoxesButton_Click(object sender, EventArgs e)
        {
            ClearListBoxes();
        }
    }


}
