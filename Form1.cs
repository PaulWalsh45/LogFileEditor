using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogFileEditor
{
    public partial class Form1 : Form
    {
        List<string> ReadLines = new List<string>();
        
        


        public Form1()
        {
            InitializeComponent();
            txtWriteFilepath.Text = "LogFilesAll_Id.txt";//Loads the filepath to the write file text box, if you wish to write to same file all the time
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {

            var filepath = txtReadFilepath.Text;
            StreamReader reader = new StreamReader(filepath);
            string line = null;
            int count = 0;

            //<-- comment one of the following 2 lines depending if you want to filter the Read or Not -->
            //count = ReadTextFileWithFilter(reader, count);
            count = ReadTextFile(reader, count);

            reader.Close();
            MessageBox.Show("Lines in File: " + count.ToString());
        }

        private int ReadTextFile(StreamReader reader, int count)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                ReadLines.Add(line); 
                count++;
            }
            return count;
        }

        private int ReadTextFileWithFilter(StreamReader reader, int count)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains("Quest.Internal/People/Profile/"))
                {
                    ReadLines.Add(line);
                    count++;
                }
            }
            return count;
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            
            
            var filepath = txtWriteFilepath.Text;

            StreamWriter writer = new StreamWriter(filepath);

            foreach (var str in ReadLines)
            {
                writer.WriteLine(ExtractNumber(str));
                //writer.WriteLine(str);
            }
            writer.Close();
            MessageBox.Show("Success");
        }

        public string ExtractNumber(string line)
        {
            List<string> WriteLines = new List<string>(); 
            string personId = null;
            string[] lineContent = line.Split(' ');
            char[] charsToTrim = { '/' };

            foreach (var element in lineContent)
            {
                
                if (element.Contains("Quest.Internal/People/Profile/"))
                {
                    int idLength = element.Length;
                    int startOfId = 30;
                    int endOfId = idLength - startOfId;
                    int duplicatesFound = 0;
                    
                    
                    personId = element.Substring(startOfId, endOfId);
                    personId=personId.Trim(charsToTrim);//trim leading slashes

                    //trim from trailing slash onwards
                    int indexOfTrailingSlash = personId.IndexOf("/");
                    if (indexOfTrailingSlash>0)
                    {
                        personId=personId.Substring(0,indexOfTrailingSlash);
                        
                        //check for duplicate Id's and return empty string if Id already exists
                        if (!(WriteLines.Contains(personId)))
                        {
                            WriteLines.Add(personId); 
                            
                        }
                        else
                        {
                            MessageBox.Show("duplicates found: " + personId);
                            personId = String.Empty;
                            duplicatesFound++;
                            
                        }
                        

                    }

                }
            }
            return personId;
        }

        private void btnAppendFile_Click(object sender, EventArgs e)
        {
            
            var filepath = txtWriteFilepath.Text;

            StreamWriter writer = new StreamWriter(filepath);

            foreach (var str in ReadLines)
            {
                writer.Write(str+",");
            }
            writer.Close();
            MessageBox.Show("Success");
        }
    }
}
