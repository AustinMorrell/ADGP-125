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
        public ADGP125()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (game.fsm.ChangeState("Battle"))
            {
                Battle();
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (game.fsm._currentState == "pause")
            {
                // I make the path to the file.
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SaveData.xml";
                // Make the file.
                System.IO.FileStream file = System.IO.File.Create(path);
                // Write to the file.
                XmlSerializer writer = new XmlSerializer(game.Party.GetType());
                writer.Serialize(file, game.Party);
                // And then close the file.
                file.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (game.fsm._currentState == "pause")
            {
                // I make the path to the file.
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SaveData.xml";
                // Make the deserializer.
                XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
                // Make the reader for the file.
                System.IO.StreamReader reader = new System.IO.StreamReader(path);
                // Read and deserialize the file.
                game.Party = (List<Player>)serializer.Deserialize(reader);
                // Close the reader.
                reader.Close();
            }
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
            EnemyBox.Image = null;
            PartyBox.Image = null;
            game.fsm.ChangeState("Running");
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            game.fsm.ChangeState("Pause");
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
            int ActiveUnit = 0;
            Enemy BadGuy = new Enemy("Cactuar", 500, 10, 7, "", @"C:\Users\Austin.Morrell\Desktop\ADGP 125\RPG\RPG\bin\Images\big_cactuar.gif");
            EnemyBox.Image = Image.FromFile(BadGuy.Image);
            PartyBox.Image = Image.FromFile(game.Party[ActiveUnit].Image);
        }
    }
}
