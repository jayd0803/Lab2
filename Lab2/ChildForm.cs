using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public class ChildForm:IEquatable<ChildForm>
    {
        public System.Windows.Forms.Form form;
        public Color color;
        public string name;

        public ChildForm(Form form, Color color, string name)
        {
            this.form = form;
            this.color = color;
            this.name = name;
            this.form.BackColor = color;
            this.form.Text = name;
            this.form.TopLevel = false;
        }

        public bool Equals(ChildForm other)
        {
            return this.name == other.name;
        }


    }
}
