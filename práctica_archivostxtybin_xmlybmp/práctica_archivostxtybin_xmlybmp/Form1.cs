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
using System.Xml.Linq;

namespace práctica_archivostxtybin_xmlybmp
{
    public partial class Form1 : Form
    {
        char bit_one, bit_two;
        int high, wide, bytes, bitsporpixel;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            ofd_image.ShowDialog();
            FileStream bmp_file = new FileStream(ofd_image.FileName, FileMode.Open);

            if (FileBMP(bmp_file) == true)
            {
                size(bmp_file);
                High_Wide(bmp_file);
                bits_por_pixel(bmp_file);

            }

            bmp_file.Close();
        }


        private bool FileBMP(FileStream bmp_file)
        {
            BinaryReader bin = new BinaryReader(bmp_file);

            bin.BaseStream.Seek(0, SeekOrigin.Begin);
            bit_one = Convert.ToChar(bin.ReadByte());
            bin.BaseStream.Seek(1, SeekOrigin.Begin);
            bit_two = Convert.ToChar(bin.ReadByte());

            if (bit_one == 'B' && bit_two == 'M')
            {
                return true;
            }
            else
            {
                Close();
                bmp_file.Close();
                txtDatosDeImagen.Text += "No es un archivo BMP";

                return false;
            }

        }

        private int size(FileStream bmp_file)
        {
            BinaryReader bin = new BinaryReader(bmp_file);

            bin.BaseStream.Seek(2, SeekOrigin.Begin);
            bytes = bin.ReadInt32();
            txtDatosDeImagen.Text += "El tamaño del archivo en bytes: " + bytes + Environment.NewLine;

            return bytes;
        }

        private int High_Wide(FileStream bmp_file)
        {
            BinaryReader bin = new BinaryReader(bmp_file);

            bin.BaseStream.Seek(18, SeekOrigin.Begin);
            high = bin.ReadInt32();
            txtDatosDeImagen.Text += Environment.NewLine + "El alto de la imagen es de: " + high + Environment.NewLine;
            wide = bin.ReadInt32();
            txtDatosDeImagen.Text += Environment.NewLine + "El ancho de la imagen es de: " + wide + Environment.NewLine;

            return high + wide;

        }

        private int bits_por_pixel(FileStream bmp_file)
        {
            BinaryReader bin = new BinaryReader(bmp_file);

            bin.BaseStream.Seek(28, SeekOrigin.Begin);
            bitsporpixel = bin.ReadInt16();
            txtDatosDeImagen.Text += Environment.NewLine + "Los bits por pixel de la imagen son de: " + bitsporpixel;


            return bitsporpixel;
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            sfd_xml.Filter = ".xml|*.xml";
            sfd_xml.ShowDialog();
            XmlDocument xml = new XmlDocument();

            XmlFile(xml, txtNombre.Text, txtEdad.Text, txtTeléfono.Text, txtCiudad.Text, txtEmail.Text);
            txtNombre.Clear();
            txtEdad.Clear();
            txtTeléfono.Clear();
            txtCiudad.Clear();
            txtEmail.Clear();

            xml.Save(sfd_xml.FileName);
        }

        public void XmlFile(XmlDocument doc, string Nombre, string Edad, string Telefono, string Ciudad, string Email)
        {
            XmlDeclaration documento = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            XmlElement element = doc.DocumentElement;
            doc.InsertBefore(documento, element);

            XmlNode NodoPrincipal = doc.CreateElement("CATÁLOGO");
            doc.AppendChild(NodoPrincipal);
            XmlNode Nodo = doc.CreateElement("Información");
            XmlAttribute Nombre_ = doc.CreateAttribute("Nombre");
            Nombre_.Value = Nombre;
            Nodo.Attributes.Append(Nombre_);
            XmlAttribute Edad_ = doc.CreateAttribute("Edad");
            Edad_.Value = Edad;
            Nodo.Attributes.Append(Edad_);
            XmlAttribute Telefono_ = doc.CreateAttribute("Teléfono");
            Telefono_.Value = Telefono;
            Nodo.Attributes.Append(Telefono_);
            XmlAttribute Ciudad_ = doc.CreateAttribute("Ciudad");
            Ciudad_.Value = Ciudad;
            Nodo.Attributes.Append(Ciudad_);
            XmlAttribute Email_ = doc.CreateAttribute("Email");
            Email_.Value = Email;
            Nodo.Attributes.Append(Email_);

            NodoPrincipal.AppendChild(Nodo);
        }
    }
}
