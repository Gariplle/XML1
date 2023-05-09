using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
namespace proekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadEmployees();
        }
        private void LoadEmployees()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\c#\\proekt\\proekt\\XMLFile1.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int age = int.Parse(node["Age"].InnerText);
                bool programmer = bool.Parse(node["Programmer"].InnerText);
                listBox1.Items.Add(new Employee(name, age, programmer));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }
        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}