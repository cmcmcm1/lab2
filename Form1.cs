using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetAllMaterials();
        }
        string pathToXML = "Archive.xml";
        List<Material> result = new List<Material>();
        private void GetAllMaterials()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Archive.xml");
            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList nodeList = xRoot.SelectNodes("material");
            int l = nodeList.Count;
            for(int i = 0; i < l; i++)
            {
                XmlNode x = nodeList.Item(i);
                AddItems(x);
            }
        }
        private void AddItems(XmlNode x)
        {
            if (!AuthorComboBox.Items.Contains(x.SelectSingleNode("@author").Value)) AuthorComboBox.Items.Add(x.SelectSingleNode("@author").Value);
            if (!NameComboBox.Items.Contains(x.SelectSingleNode("@name").Value)) NameComboBox.Items.Add(x.SelectSingleNode("@name").Value);
            if (!FacultyComboBox.Items.Contains(x.SelectSingleNode("@faculty").Value)) FacultyComboBox.Items.Add(x.SelectSingleNode("@faculty").Value);
            if (!CathedraComboBox.Items.Contains(x.SelectSingleNode("@cathedra").Value)) CathedraComboBox.Items.Add(x.SelectSingleNode("@cathedra").Value);
            if (!SizeComboBox.Items.Contains(x.SelectSingleNode("@size").Value)) SizeComboBox.Items.Add(x.SelectSingleNode("@size").Value);
            if (!DateComboBox.Items.Contains(x.SelectSingleNode("@dateofCreating").Value)) DateComboBox.Items.Add(x.SelectSingleNode("@dateofCreating").Value);
        }
        private void Search_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Material material = new Material();
            if (Author.Checked) material.author = AuthorComboBox.SelectedItem.ToString();
            if (NameA.Checked) material.name = NameComboBox.SelectedItem.ToString();
            if (Faculty.Checked) material.faculty = FacultyComboBox.SelectedItem.ToString();
            if (Cathedra.Checked) material.cathedra = CathedraComboBox.SelectedItem.ToString();
            if (Size.Checked) material.size = SizeComboBox.SelectedItem.ToString();
            if (DateOfCreating.Checked) material.dateOfCreating = DateComboBox.SelectedItem.ToString();
            if (SAX.Checked)
            {
                IStrategy strategy = new SAX();
                this.result = strategy.Algorithm(material, pathToXML);
                if (result.Count() == 0)
                {
                    MessageBox.Show("no items found");
                }
                else
                {
                    printMaterial();
                }
            }
            else if (DOM.Checked)
            {
                IStrategy strategy = new DOM();
                this.result = strategy.Algorithm(material, pathToXML);
                if (result.Count() == 0)
                {
                    MessageBox.Show("no items found");
                }
                else
                {
                    printMaterial();
                }
            }
            else if (LINQ.Checked)
            {
                IStrategy strategy = new LINQ();
                this.result = strategy.Algorithm(material, pathToXML);
                if (result.Count() == 0)
                {
                    MessageBox.Show("no items found");
                }
                else
                {
                    printMaterial();
                }
            }
            else
            {
                MessageBox.Show("Select SAX/DOM/LINQ");
            }
        }
        private void printMaterial()
        {
            foreach (Material material in result)
            {
                richTextBox1.Text += "author: " + material.author + '\n';
                richTextBox1.Text += "name: " + material.name + '\n';
                richTextBox1.Text += "faculty: " + material.faculty + '\n';
                richTextBox1.Text += "cathedra: " + material.cathedra + '\n';
                richTextBox1.Text += "size: " + material.size + '\n';
                richTextBox1.Text += "date of creating: " + material.dateOfCreating + '\n' + '\n' + '\n';
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Author.Checked = false;
            NameA.Checked = false;
            Faculty.Checked = false;
            Cathedra.Checked = false;
            Size.Checked = false;
            DateOfCreating.Checked = false;
            SAX.Checked = false;
            DOM.Checked = false;
            LINQ.Checked = false;
            AuthorComboBox.Text = null;
            NameComboBox.Text = null;
            FacultyComboBox.Text = null;
            CathedraComboBox.Text = null;
            SizeComboBox.Text = null;
            DateComboBox = null;
            richTextBox1.Clear();
            result.Clear();
        }

        private void TOHTML_Click(object sender, EventArgs e)
        {
            Transform();
        }
        private void Transform()
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load("xml_to_html.xsl");
            string fileXML = pathToXML;
            string fileHTML = "Archive.html";
            xct.Transform(fileXML, fileHTML);
            MessageBox.Show("Succesfully transformed");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {

            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
