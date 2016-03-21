using System;
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
            game.fsm.ChangeState("Battle");
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SaveData.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            foreach (Player a in game.Party)
            {
                XmlSerializer writer = new XmlSerializer(a.GetType());
                writer.Serialize(file, a);
            }
            file.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
