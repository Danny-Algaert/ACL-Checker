using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVE_ACL_Checker
{
    public partial class ACL_Checker : Form
    {
        private string[] ACLAlts;
        private string[] ACLMembers;
        private Dictionary<string, List<string>> AltAssociations;
        private static string CORPID = "917701062";


        public ACL_Checker()
        {
            InitializeComponent();
            AltAssociations = new Dictionary<string, List<string>>();
        }

        //Reads the members from the specified ALT ACL file
        private void ReadAltACL(string path)
        {
            ACLAlts = System.IO.File.ReadAllLines(path);
            foreach (string name in ACLAlts)
            {
                AltsACLTextBox.Text += name + Environment.NewLine;
            }           
       }

        //Reads the members from the specified Members ACL file
        private void ReadMemberACL(string path)
        {
            ACLMembers = System.IO.File.ReadAllLines(path);
            foreach (string name in ACLMembers)
            {
                MainsACLTextBox.Text += name + Environment.NewLine;
            }
        } 

        //Creates a mapping between alts and mains. Some issues may occur with characters used as
        //alts by multiple characters of the same player
        private void AssociatieAlts(string path)
        {
            string[] association = new string[2];
            string[] AltFile = System.IO.File.ReadAllLines(path);
            for (int i = 0; i < AltFile.Length; ++i)
            {
                association = AltFile[i].Split(',');
                if (association.Length >= 2)
                {
                    if (AltAssociations.ContainsKey(association[1]))
                    {
                        AltAssociations[association[1]].Add(association[0]);
                        AltAssociationsTextBox.Text += association[1] + " alt of " + association[0] + Environment.NewLine; ;
                    }
                    else
                    {
                        AltAssociations.Add(association[1], new List<string> { association[0] });
                        AltAssociationsTextBox.Text += association[1] + " alt of " + association[0] + Environment.NewLine; ;
                    }
                }
            }
        }

        private void CheckAlts()
        {
            List<string> fakeOut = new List<string>();
            foreach (string alt in ACLAlts)
            {
                if (AltAssociations.ContainsKey(alt))
                {
                    foreach (string main in AltAssociations[alt])
                    {
                        string mainCorpID = ApiWebFetcher.GetCharactersCorpByName(main, OutputTextBox);
                        if (!mainCorpID.Equals(CORPID))
                        {
                            OutputTextBox.Text += main + " not a member of Eve University. Alt name: " + alt + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    OutputTextBox.Text += "Main not found for alt: " + alt + Environment.NewLine;
                }
               
            }
        }

        private void CheckMembers()
        {
            
            foreach (string member in ACLMembers)
            {
                string memberCorpID = ApiWebFetcher.GetCharactersCorpByName(member, OutputTextBox);
                if (memberCorpID != "" && !(memberCorpID.Equals(CORPID)))
                {
                    OutputTextBox.Text += member + " not a member of Eve University" + Environment.NewLine;
                }
            }
        }

        private void MainsACLFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "txt files (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ReadMemberACL(dialog.FileName);
            }           
        }

        private void AltsACLFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "txt files (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ReadAltACL(dialog.FileName);
            }
        }

        private void AltAssociationsFileButton_Click(object sender, EventArgs e)
        {
            if (ACLAlts == null || ACLAlts.Length == 0)
            {
                MessageBox.Show("Load alt ACL first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "csv files comma delimited (*.csv)|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AssociatieAlts(dialog.FileName);
            }
        }

        private void MembersACLAnalyzeButton_Click(object sender, EventArgs e)
        {
            if (MainsACLTextBox.Text != "")
            {
                CheckMembers();
            }
            else
            {
                MessageBox.Show("Load a text file containing the ACL to check", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void AltsACLAnalyzeButton_Click(object sender, EventArgs e)
        {
            if (AltsACLTextBox.Text != "" && AltAssociationsTextBox.Text != "")
            {
                CheckAlts();
            }
            else
            {
                MessageBox.Show("Load a text file containing the ACL to check and ensure you've loaded a CSV file containing mains in column 1 and alts in column 2", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OutputFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "txt files (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(dialog.FileName, OutputTextBox.Text);
            }
        }
    }
}
