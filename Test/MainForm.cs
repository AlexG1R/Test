using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace Test
{
    public partial class MainForm : Form
    {       
        public MainForm()
        {
             
            InitializeComponent();
        }
        private List<string> SaveIdObjects { get; set; } //Id сохранённых объектов
        private List<string> NameObject { get; set; } //Имена объектов
        private List<string> NameGroupObjects { get; set; }//Имена групп объектов
        private List<string> NameIdObject { get; set; }//Имена Id объектов 
        private XmlDocument XmlDoc { get; set; }//Загружаемый XML документ
        private Object Doc { get; set; }//Первоначальный объекты, который содержит весь XML документ
        private List<Object> Objects { get; set; } //Группа объектов
        private void WriteXMlFiletoRichBox()//Выводит текст выбранного XML документа
        {              
                openRichTextBox.Text = File.ReadAllText(openFileDialog.FileName);                                  
        }
        private void LoadXmlDoc()//Загружает выбранный XML файл в переменную
        {
            XmlDoc = new XmlDocument();            
            XmlDoc.Load(openFileDialog.FileName);
            Doc = new Object();
            Doc.XmlNode = XmlDoc;         
        }
        private void CreateProperties()
        {
            NameIdObject = new List<string> { "cad_number", "reg_numb_border" };
            NameGroupObjects = new List<string>() { "land_records" , "build_records", 
                                                    "construction_records", "spatial_data",
                                                    "municipal_boundaries", "zones_and_territories_boundaries"};
            NameObject = new List<string> { "land_record", "build_record",
                                             "construction_record", "spatial_data",
                                             "municipal_boundary_record", "zones_and_territories_record"};
            Objects  = new List<Object>();
            SaveIdObjects = new List<string>();
        }
        private void GetObjects(Object objectNode, string nameObject, List<string> nameIdObjects, string NameGroupObject)//Поиск и добавление объектов
        {  
            if (objectNode.XmlNode.HasChildNodes)//Если узел имеет дочерние узлы
            {
                foreach (XmlNode child in objectNode.XmlNode.ChildNodes)//Проходит по всем дочерним узлам
                {
                    if (child.Name == nameObject)//Если находит узел схожий с названием объекта
                    {
                        Object newobj = new Object();//создаёт объект
                        newobj.XmlNode = child;//записывает узел в объект
                        Objects.Add(newobj);//добавляет новый объект в коллекцию
                        WriteId(child, nameIdObjects, NameGroupObject);//Поиск и запись Id объекта
                        if (Objects[Objects.Count - 1].IdObject == null)//Если Id не найден, то Id записывается как номер объекта в группе
                        {
                            Objects[Objects.Count - 1].IdObject = (objectstTeeView.Nodes[NameGroupObject].Nodes.Count + 1).ToString();
                            objectstTeeView.Nodes[NameGroupObject].Nodes.Add(Objects[Objects.Count - 1].IdObject);                            
                        }
                    }
                    else//Если не находит узел схожий с объектом, переходит к следующему дочернему узлу
                    {
                        objectNode.XmlNode = child;
                        GetObjects(objectNode, nameObject, nameIdObjects, NameGroupObject);
                    }
                }
            }
        }
        private void WriteId(XmlNode objectNode, List<string> nameIdObjects, string NameGroupObject)//Поиск Id объекта
        {
            if (objectNode.HasChildNodes)
            {
                foreach (XmlNode child in objectNode.ChildNodes)
                {

                    if (nameIdObjects.Contains(child.Name))//если находит узел похожий на имя Id
                    {
                        if (Objects[Objects.Count - 1].IdObject == null)//Записывает первый Id, найденный в объекте
                        {
                            Objects[Objects.Count - 1].IdObject = child.InnerText;
                            objectstTeeView.Nodes[NameGroupObject].Nodes.Add(child.InnerText);
                        }
                    }
                    else
                    {
                        WriteId(child, nameIdObjects, NameGroupObject);
                    }
                }

            }

        }
        private void WriteObject()//Выводит объект в поле "Содержимое объекта(ов)"
        {
            //Для того, чтобы вывести содержимое объекта с сохранением разметки, необходимо сначла создать файл и извлечь текст, а затем удалить файл
            SaveIdObjects.Clear();
            objectRichTextBox.Clear();
            XmlDocument xml = new XmlDocument();
            for (int i = 0; i < Objects.Count; i++)
            {
                if (Objects[i].IdObject == objectstTeeView.SelectedNode.Text)
                {                  
                    xml.AppendChild(xml.ImportNode(Objects[i].XmlNode, true));
                    xml.Save("object");
                    objectRichTextBox.Text = File.ReadAllText("object");
                    File.Delete("Object");
                    SaveIdObjects.Add(Objects[i].IdObject);
                }
            }
        }
        private void SaveObjects()//Сохраняет содержимое объекта или нескольких объектов
        {
            saveFileDialog.Filter = "Xml документ (*.xml)|*.xml";
            saveFileDialog.ShowDialog();
            XmlDocument xml = new XmlDocument();           
            XmlElement root = xml.CreateElement("objects");
            if (SaveIdObjects!=null)//проверяет, есть ли объекты для сохранения
            {
                foreach (var saveobjct in SaveIdObjects)
                {
                    for (int i = 0; i < Objects.Count; i++)
                    {
                        if (Objects[i].IdObject == saveobjct)//Добавляет объект в файл, если находит в коллекции объектов
                        {                      
                            root.AppendChild(xml.ImportNode(Objects[i].XmlNode, true));   
                        }                   
                    }                
                }
                xml.AppendChild(root);
                xml.Save(saveFileDialog.FileName); 
            }          
        }
        private void AddObject()//Добавляет содержание объекта в поле "Содержание объекта(ов)"
        {
            if (Objects!=null)//Проверяет, есть ли объекты в коллекции
            {
                XmlDocument xml = new XmlDocument();
                for (int i = 0; i < Objects.Count; i++)
                {
                    if (Objects[i].IdObject == objectstTeeView.SelectedNode.Text)
                    {
                        xml.AppendChild(xml.ImportNode(Objects[i].XmlNode, true));
                        xml.Save("object");
                        objectRichTextBox.Text += File.ReadAllText("object");
                        File.Delete("Object");
                        SaveIdObjects.Add(Objects[i].IdObject);
                    }
                }
            }
            else
            {
                MessageBox.Show("Нажмите на объект, до того, как добавить его в поле 'Содержимое объекта(ов)'", "Ошибка!");
            }
        }
        private void openFileButton_Click(object sender, EventArgs e)
        {
            CreateProperties();
            if (openFileDialog.ShowDialog() == DialogResult.OK)//проверяет, выбран ли файл
            {
                WriteXMlFiletoRichBox();          
                LoadXmlDoc();              
                for (int i = 0; i < NameGroupObjects.Count; i++)
                {
                    objectstTeeView.Nodes[NameGroupObjects[i]].Nodes.Clear();//Очистка объектов из списка "Объекты", если выбран новый файл
                    GetObjects(Doc, NameObject[i], NameIdObject, NameGroupObjects[i]);//Нахождение и добавление объектов в список "Объекты"
                    Doc.XmlNode = XmlDoc;
                } 
            }                      
        }             
        private void objectstTeeView_NodeMouseDoubleClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {            
            if (objectstTeeView.SelectedNode.Parent!=null)//Если имеется родительский узел, значит это объект
            {
                SaveIdObjects.Clear();
                WriteObject();             
            }        
        }           
        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveObjects();
        }
        private void addObjBtn_Click(object sender, EventArgs e)
        {
            AddObject();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ActiveControl = objectstTeeView;
        }
        private void clearingObjectRichBox_Click(object sender, EventArgs e)
        {
            objectRichTextBox.Clear();
            SaveIdObjects.Clear();
        }
    }
}
