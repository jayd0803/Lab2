using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Parent : System.Windows.Forms.Form
    {
        public Color currentColor = Color.Red;

        public List<ChildForm> childrenForms = new List<ChildForm>();


        public Parent()
        {
            InitializeComponent();
            updateColor();

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentColor = Color.Green;
            updateColor();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentColor = Color.Blue;
            updateColor();
        }

        private void createNewChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var unique = false;
            var lblText = "Please enter the child form name: ";
            while (!unique)
            {
                var formName = ShowDialog(lblText, 300, 100);
                if (formName != "")
                {
                    ChildForm newChild = new ChildForm(new Form(), currentColor, formName);

                    if (!childrenForms.Contains(newChild))
                    {
                        childrenForms.Add(newChild);
                        newChild.form.MdiParent = this;
                        newChild.form.Show();
                        unique = true;
                    }
                    else
                    {
                        lblText = "Form names must be unique";
                    }

                }
            }
            
        }

        public void updateColor() {
            lblTssColor.Text = "Color :" + currentColor.Name;
            lblTssColor.BackColor = currentColor; 
        }

        public static string ShowDialog(string text,int width,int height)
        {
            Form prompt = new Form()
            {
                Width = width,
                Height = height,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterParent
            };
            Label textLabel = new Label() {Text = text,Left=20,Top=20,Width=200 };
            TextBox textBox = new TextBox() { Left= 200,Width = 80, Top = 20 };
            Button confirmation = new Button() { Text = "Ok",Left=20, Width = 50,Top=40 ,DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.BackColor = Color.Teal;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
           
        }

        private void closeAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ChildForm c in childrenForms) {
                c.form.Close();
            }
            childrenForms.Clear();
        }

        private void cascadeAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentColor = Color.Red;
            updateColor();
        }

        private void Parent_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                lbltssName.Text = "Active Child: " + ActiveMdiChild.Text;
            else
                lbltssName.Text = "Active Child: None";

        }

        private void listAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form list = new Form()
            {
                Width = 300,
                Height = 300,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.Teal
            };
            ListBox children = new ListBox();
            foreach (ChildForm c in childrenForms) {
                children.Items.Add("Name: " + c.name + ", Color: " + c.color.Name);
            }
            Label lblText = new Label { Text = "List of all Child forms", Left = 50, Top = 30, Width = 200 };
            children.Width = 200;
            children.Height = 200;
            children.Left = 50;
            children.Top = 50;
            Button close = new Button() { Text = "Close", Width = 50, Left = 200, Top = 20 };
            close.Click += (s, eve) => { list.Close(); };

            list.Controls.Add(children);
            list.Controls.Add(close);
            list.Controls.Add(lblText);
            list.Show();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if( cd.ShowDialog() == DialogResult.OK)
            {
                currentColor = cd.Color;
            }
            updateColor();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form test = new Form();
            test.MaximizeBox = false;
            test.MinimizeBox = false;
            test.FormBorderStyle = FormBorderStyle.FixedDialog;
            test.Width = 300;
            test.Height = 150;
            test.Icon = null;
            test.Text = "About";
            test.StartPosition = FormStartPosition.CenterParent;

            Label a = new Label { Text = "Multiple Document Interface program \nLab2 by Jie \nOct 2018", Width = 200, Left = 50,Top=30,Height=120 };
            test.Controls.Add(a);

            test.ShowDialog();
        }

        private void Parent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
