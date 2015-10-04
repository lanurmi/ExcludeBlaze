using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcludeBlaze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadBZlines();
            loadYourLines();
        }

        void loadBZlines()
        {
            string[] lines = System.IO.File.ReadAllLines(getBZinfoPath());
            string[] entries = new string[lines.Length];
            int entryIndex = 0;

            foreach (string line in lines)
            {
                string s = getPathFromLine(line);
                if (s.Length > 0 && !isDefaultPath(s))
                    entries[entryIndex++] = s;
            }

            Array.Sort(entries);

            foreach (string entry in entries)
            {
                if (entry != null)
                    BZpathsBox.Items.Add(entry);
            }

            updateBoxCounts();
        }

        void loadYourLines()
        {
            try
            {
                string[] ownPaths = System.IO.File.ReadAllLines(getYourPathsPath());

                Array.Sort(ownPaths);

                foreach (string p in ownPaths)
                    YourPathsBox.Items.Add(p); // TODO: highlight new items
            }
            catch (Exception)
            {

            }
            updateBoxCounts();
        }

        private void updateBoxCounts()
        {
            yourPathsCount.Text = YourPathsBox.Items.Count.ToString();
            bzBoxCount.Text = BZpathsBox.Items.Count.ToString();
        }

        static private string getBZinfoPath()
        {
            return @"C:\ProgramData\BackBlaze\bzdata\bzinfo.xml";
        }

        static private string getYourPathsPath()
        {
            string ebpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ExcludeBlaze";
            if (!System.IO.Directory.Exists(ebpath))
                System.IO.Directory.CreateDirectory(ebpath);
            return ebpath + @"\ebpaths.txt";
        }

        private bool isDefaultPath(string path)
        {
            string[] defaultPaths = {
                                        @"c:\windows\",
                                        @"c:\i386\",
                                        @"c:\$recycle.bin\",
                                        @"c:\$recycler\",
                                        @"c:\msocache\",
                                        @"c:\program files\",
                                        @"c:\program files (x86)\",
                                        @"c:\users\all users\microsoft\",
                                        @"c:\users\all users\microsoft help\",
                                        @"c:\$windows.~bt\",
                                        @"c:\recycler\"
                                    };

            foreach (string dpath in defaultPaths)
            {
                // Ignore the drive letter in comparison.
                if (dpath.ToLower().Substring(1) == path.ToLower().Substring(1))
                    return true;
            }
            return false;
        }

        private string getPathFromLine(string line)
        {
            string searchFor = "<bzdirfilter dir=\"";
            int index = line.IndexOf(searchFor);
            if (index != -1)
            {
                string[] elements = line.Split('\"');
                if (elements[3].Equals("none"))
                    return elements[1];
            }
            return "";
        }

        private bool pathAlreadyListed(string[] lines, string path)
        {
            foreach (string line in lines)
            {
                string s = getPathFromLine(line);
                if (s.Equals(path))
                    return true;
            }
            return false;
        }

        private void writeBZinfo(string[] paths)
        {
            string[] lines = System.IO.File.ReadAllLines(getBZinfoPath());
            System.IO.TextWriter tw = new System.IO.StreamWriter(getBZinfoPath(), false);

            foreach (string line in lines)
            {
                if (line.Equals("</do_backup>"))
                {
                    foreach (string path in paths)
                    {
                        if (!pathAlreadyListed(lines, path))
                        {
                            string filterline = String.Format("    <bzdirfilter dir=\"{0}\" whichfiles=\"none\" />", path);
                            tw.WriteLine(filterline);
                        }
                    }
                }
                tw.WriteLine(line);
            }
            tw.Close();
        }

        private void writeYourPaths(string[] paths)
        {
            System.IO.File.WriteAllLines(getYourPathsPath(), paths);
        }

        private void mergeToBZbutton_Click(object sender, EventArgs e)
        {
            foreach (string yourpath in YourPathsBox.Items)
                if (BZpathsBox.Items.Contains(yourpath) == false)
                    BZpathsBox.Items.Add(yourpath);

            string[] paths = BZpathsBox.Items.Cast<string>().ToArray();

            writeBZinfo(paths);

            updateBoxCounts();
        }

        private void mergeFromBZbutton_Click(object sender, EventArgs e)
        {
            foreach (string bzpath in BZpathsBox.Items)
                if (YourPathsBox.Items.Contains(bzpath) == false)
                    YourPathsBox.Items.Add(bzpath);

            string[] paths = YourPathsBox.Items.Cast<string>().ToArray();

            writeYourPaths(paths);
            updateBoxCounts();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
                YourPathsBox.Items.Add((dlg.SelectedPath + @"\").ToLower());

            updateBoxCounts();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (YourPathsBox.SelectedIndex != -1)
                YourPathsBox.Items.RemoveAt(YourPathsBox.SelectedIndex);
            updateBoxCounts();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
