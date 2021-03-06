﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSM_Program;
using System.Xml;
using Combat_Program;
using System.Xml.Serialization;
namespace RPG
{
    public partial class ADGP125 : Form
    {
        Game game = new Game();
        int ActiveUnit = 0;
        Enemy BadGuy;
        List<Button> MoveButtons = new List<Button>();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        bool IsPlaying = true;

        public ADGP125()
        {
            InitializeComponent();
            MoveButtons.Add(AttackO1);
            MoveButtons.Add(AttackO2);
            MoveButtons.Add(AttackO3);
            playSound(Environment.CurrentDirectory + "\\LWD.wav");
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Battle();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            //Environment.CurrentDirectory + @"\Images\"
        }

        private void button2_Click(object sender, EventArgs e)
        {
                // I make the path to the file.
                var path = Environment.CurrentDirectory + "\\SaveData.xml";
                // Make the file.
                System.IO.FileStream file = System.IO.File.Create(path);
                // Write to the file.
                XmlSerializer writer = new XmlSerializer(game.Party.GetType());
                writer.Serialize(file, game.Party);
                // And then close the file.
                file.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                // I make the path to the file.
                var path = Environment.CurrentDirectory + "\\SaveData.xml";
                // Make the deserializer.
                XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
                // Make the reader for the file.
                System.IO.StreamReader reader = new System.IO.StreamReader(path);
                // Read and deserialize the file.
                game.Party = (List<Player>)serializer.Deserialize(reader);
                // Close the reader.
                reader.Close();
        }

        private void RunAway()
        {
            EnemyBox.Image = null;
            PartyBox.Image = null;
            BattleBox.Text = null;
            AttackO1.Text = null;
            AttackO2.Text = null;
            AttackO3.Text = null;
            EnemyHPBar.Value = 0;
            PartyHPBar.Value = 0;
        }

        private void playSound(string path)
        {
            player.SoundLocation = path;
            player.PlayLooping();
        }

        private void PartyBox_Click(object sender, EventArgs e)
        {

        }

        private void EnemyBox_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void EnemyHPBar_Click(object sender, EventArgs e)
        {

        }

        private void Run_Click(object sender, EventArgs e)
        {
            RunAway();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            
        }

        private void EXPBar_Click(object sender, EventArgs e)
        {

        }

        private void NameLable_Click(object sender, EventArgs e)
        {

        }

        private void LevelLable_Click(object sender, EventArgs e)
        {

        }

        private void HPNumb_Click(object sender, EventArgs e)
        {

        }

        private void StatusLable_Click(object sender, EventArgs e)
        {

        }

        private void AttackLable_Click(object sender, EventArgs e)
        {

        }

        private void DefenceLable_Click(object sender, EventArgs e)
        {

        }

        private void EName_Click(object sender, EventArgs e)
        {

        }

        private void EnemyHPNumb_Click(object sender, EventArgs e)
        {

        }

        private void EStatus_Click(object sender, EventArgs e)
        {

        }

        private void ELevelLable_Click(object sender, EventArgs e)
        {

        }

        public void Battle()
        {
            ActiveUnit = 0;
            BadGuy = new Enemy("Cactuar", 500, 10, 7, "", Environment.CurrentDirectory + @"\Images\big_cactuar.gif", 2, 3, 5);
            foreach (Player j in game.Party)
            {
                j.HP = j.maxHP;
            }
            BadGuy.HP = BadGuy.maxHP;
            ActiveBattle();
        }

        public void ActiveBattle()
        {
            if (ActiveUnit >= game.Party.Count)
            {
                ActiveUnit = 0;
            }

            if (game.Party[ActiveUnit].HP <= 0)
            {
                ActiveUnit += 1;
            }

            if (ActiveUnit >= game.Party.Count)
            {
                ActiveUnit = 0;
            }

            if (BadGuy.HP <= 0)
            {
                game.Party[ActiveUnit].EXP += BadGuy.EXPDrop;
                if (game.Party[ActiveUnit].EXP > game.Party[ActiveUnit].Curve[game.Party[ActiveUnit].Level])
                {
                    game.Party[ActiveUnit].LevelUp();
                }
            }
            //------------------------------------------------------------------------------------------------------------------------------------//
            EnemyBox.Image = Image.FromFile(BadGuy.Image);
            PartyBox.Image = Image.FromFile(game.Party[ActiveUnit].Image);
            NameLable.Text = game.Party[ActiveUnit].Name;
            LevelLable.Text = "Level: " + game.Party[ActiveUnit].Level.ToString();
            StatusLable.Text = game.Party[ActiveUnit].Status;
            AttackLable.Text = "ATK: " + game.Party[ActiveUnit].AttackP.ToString();
            DefenceLable.Text = "   DEF: " + game.Party[ActiveUnit].Defence.ToString();
            EXPBar.Maximum = (int)game.Party[ActiveUnit].Curve[game.Party[ActiveUnit].Level + 1];
            PartyHPBar.Maximum = (int)game.Party[ActiveUnit].maxHP;
            EXPBar.Value = (int)game.Party[ActiveUnit].EXP;
            PartyHPBar.Value = (int)game.Party[ActiveUnit].HP;
            HPNumb.Text = "HP: " + game.Party[ActiveUnit].HP + " / " + game.Party[ActiveUnit].maxHP;
            //------------------------------------------------------------------------------------------------------------------------------------//
            EName.Text = BadGuy.Name;
            ELevelLable.Text = "Level: " + BadGuy.Level.ToString();
            EStatus.Text = BadGuy.Status;
            EnemyHPNumb.Text = "HP: " + BadGuy.HP + " / " + BadGuy.maxHP;
            EnemyHPBar.Maximum = (int)BadGuy.maxHP;
            if (BadGuy.HP <= 0)
            {
                BadGuy.HP = 0;
            }
            EnemyHPBar.Value = (int)BadGuy.HP;
            //------------------------------------------------------------------------------------------------------------------------------------//
            for (int i = 0; i < 3; i++)
            {
                AttackNames(i);
            }
            if (BadGuy.HP <= 0)
            {
                RunAway();
                BattleBox.Text += "You Win!\n";
            }
        }

        private void AttackO1_Click(object sender, EventArgs e)
        {
                switch (game.Party[ActiveUnit].Moves[0])
                {
                    case 1:
                        game.Party[ActiveUnit].Attack(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Attack.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    case 2:
                        game.Party[ActiveUnit].Fire(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Fire.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    case 3:
                        game.Party[ActiveUnit].Heal(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Heal.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    case 4:
                        game.Party[ActiveUnit].Freeze(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Freeze.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    case 5:
                        game.Party[ActiveUnit].Poison(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Poison.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    default:
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;
            }
        }

        private void AttackO2_Click(object sender, EventArgs e)
        {
                switch (game.Party[ActiveUnit].Moves[1])
                {
                    case 1:
                        game.Party[ActiveUnit].Attack(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Attack.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    case 2:
                        game.Party[ActiveUnit].Fire(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Fire.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    case 3:
                        game.Party[ActiveUnit].Heal(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Heal.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    case 4:
                        game.Party[ActiveUnit].Freeze(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Freeze.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    case 5:
                        game.Party[ActiveUnit].Poison(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Poison.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    default:
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;
            }
        }

        private void AttackO3_Click(object sender, EventArgs e)
        {
                switch (game.Party[ActiveUnit].Moves[2])
                {
                    case 1:
                        game.Party[ActiveUnit].Attack(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Attack.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    case 2:
                        game.Party[ActiveUnit].Fire(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Fire.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    case 3:
                        game.Party[ActiveUnit].Heal(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Heal.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    case 4:
                        game.Party[ActiveUnit].Freeze(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Freeze.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    case 5:
                        game.Party[ActiveUnit].Poison(BadGuy);
                        BattleBox.Text += game.Party[ActiveUnit].Name + " used Poison.\n";
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;

                    default:
                        ActiveUnit += 1;
                        EnemyAttack();
                        ActiveBattle();
                        break;
            }
        }

        private bool EnemyAttack()
        {
            if (ActiveUnit == game.Party.Count)
            {
                Random rnd1 = new Random();
                Random rnd2 = new Random();
                int target = rnd1.Next(0, game.Party.Count);
                int move = rnd2.Next(0, BadGuy.Moves.Count);
                switch (move)
                {
                    case 1:
                        BadGuy.Attack(game.Party[target]);
                        BattleBox.Text += BadGuy.Name + " used Attack.\n";
                        return true;

                    case 2:
                        BadGuy.Fire(game.Party[target]);
                        BattleBox.Text += BadGuy.Name + " used Fire.\n";
                        return true;

                    case 3:
                        BadGuy.Heal(game.Party[target]);
                        BattleBox.Text += BadGuy.Name + " used Heal.\n";
                        return true;

                    case 4:
                        BadGuy.Freeze(game.Party[target]);
                        BattleBox.Text += BadGuy.Name + " used Freeze.\n";
                        return true;

                    case 5:
                        BadGuy.Poison(game.Party[target]);
                        BattleBox.Text += BadGuy.Name + " used Poison.\n";
                        return true;

                    default:
                        break;
                }
            }
            return true;
        }

        private void AttackNames(int i)
        {
            switch (game.Party[ActiveUnit].Moves[i])
            {
                case 1:
                    MoveButtons[i].Text = "Attack";
                    break;

                case 2:
                    MoveButtons[i].Text = "Fire";
                    break;

                case 3:
                    MoveButtons[i].Text = "Heal";
                    break;

                case 4:
                    MoveButtons[i].Text = "Freeze";
                    break;

                case 5:
                    MoveButtons[i].Text = "Poison";
                    break;

                default:
                    MoveButtons[i].Text = "";
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IsPlaying)
            {
                IsPlaying = false;
                player.Stop();
            }
            else
            {
                player.PlayLooping();
                IsPlaying = true;
            }
        }
    }
}
