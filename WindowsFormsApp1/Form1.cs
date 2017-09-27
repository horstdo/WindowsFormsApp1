using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Principal;
using Domino;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static class Roles
        {
            public const string Administrator = "ADMIN";
        }

        public Form1()
        {
            InitializeComponent();

            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("Fred"), new string[] { Roles.Administrator });
//            DeleteDatabase(); // fine
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("Barney"), new string[] { });
        }

        private void BTListBoxFuellen_Click(object sender, EventArgs e)
        {

            listBox1.BeginUpdate();
            // Loop through and add 50 items to the ListBox.
            for (int x = 1; x <= 50; x++)
            {
                listBox1.Items.Add("Item " + x.ToString());
            }
            // display the new items.
            listBox1.EndUpdate();

            // Select three items from the ListBox.
            listBox1.SetSelected(1, true);
        }

        private void BTListBoxEintraegeLoeschen_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }

        }
        
        private void BTListBoxTextAnhaengen_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;

            if ( !a.Equals(""))
            {
                listBox1.BeginUpdate();
                listBox1.Items.Add(textBox1.Text);
                listBox1.EndUpdate();
                textBox1.Clear();

            }
            else
            {
                MessageBox.Show("Es wurde kein Text eingetragen!", "Fehler", MessageBoxButtons.OK);
            }

            ControlSetFocus(textBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Form wird geladen", "Info", MessageBoxButtons.OK);
        }

        private void SortListBoxItems(ref ListBox lb, bool ascending)
        {
            List<object> items;
            items = lb.Items.OfType<object>().ToList();
            lb.Items.Clear();
            if (ascending)
            { lb.Items.AddRange(items.OrderBy(i => i).ToArray()); }
            else
            { lb.Items.AddRange(items.OrderByDescending(i => i).ToArray()); }
        }

        private void BTNotes_Click(object sender, EventArgs e)
        {

            NotesSession session = new NotesSession();
            session.Initialize("");

            NotesDatabase db = session.GetDatabase("eva/mpreis", "names.nsf"  );
            NotesView view = db.GetView("x");
            NotesViewEntryCollection col = view.AllEntries;

            listBox2.BeginUpdate();

            string strTest;
            string strTest1;

            for (int iZaehler = 1; iZaehler <= col.Count; iZaehler++)
            {

                NotesViewEntry entry = col.GetNthEntry(iZaehler);
                NotesDocument doc = entry.Document;

                NotesItem FirstName = doc.GetFirstItem("FirstName");
                NotesItem LastName = doc.GetFirstItem("LastName");

                strTest = FirstName.Text;
                strTest1 = LastName.Text;

                listBox2.Items.Add(strTest + " " + strTest1);

            }

            listBox2.EndUpdate();
            
            //
        }

        public void ControlSetFocus(Control control)
        {
            // Set focus to the control, if it can receive focus.
            if (control.CanFocus)
            {
                control.Focus();
            }
        }
        // Eingaben prüfen
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                string a = textBox1.Text;

                if (!a.Equals(""))
                {
                    listBox1.BeginUpdate();
                    listBox1.Items.Add(textBox1.Text);
                    listBox1.EndUpdate();
                    textBox1.Clear();
                                       
                }

                ControlSetFocus(textBox1);
            }

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SortListBoxItems(ref listBox1, true);
                checkBox1.Text = "Aufsteigend";
            }
            else
            {
                SortListBoxItems(ref listBox1, false);
                checkBox1.Text = "Absteigend";
            }
        }

        private void ButtonSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
