using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace XML_Home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            tbInstname.Text = string.Empty;
            cmbType.SelectedIndex = 0;
            nudYear_of_origin.Value = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SerializeXML(Names names)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Names));

            using (FileStream fs = new FileStream("Names.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, names);
            }
        }

        private Names DeserializeXML()
        {

            XmlSerializer xml = new XmlSerializer(typeof(Names));

            using (FileStream fs = new FileStream("Names.xml", FileMode.OpenOrCreate))
            {
                return (Names)xml.Deserialize(fs);

            }

        }

        private void Add(Name name)
        {
            ListViewItem LVI = new ListViewItem(name.Instname);
            LVI.Tag = name;

            lvNames.Items.Add(LVI);
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {

            Names names = new Names();
            
            foreach(ListViewItem item in lvNames.Items)
            {
                if(item.Tag != null)
                {
                    names.NamesList.Add((Name)item.Tag);
                }
            }

            SerializeXML(names);
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            ClearInput();
            Names names = DeserializeXML();

            foreach(Name name in names.NamesList)
            {
                Add(name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Name name = new Name(tbInstname.Text, cmbType.SelectedIndex, (int)nudYear_of_origin.Value);

            Add(name);

            ClearInput();
        }

        private void lwNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvNames.SelectedItems.Count == 1)
            {
                Name name = (Name)lvNames.SelectedItems[0].Tag;

                if(name != null)
                {
                    tbInstname.Text = name.Instname;
                    cmbType.SelectedIndex = name.Type;
                    nudYear_of_origin.Value = name.Year_of_origin;
                }
            }
            else if (lvNames.SelectedItems.Count == 0)
            {
                ClearInput();
            }
        }

        private void tbInstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudYear_of_origin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
