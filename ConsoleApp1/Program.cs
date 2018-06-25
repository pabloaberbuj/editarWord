using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xceed.Words.NET;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
//using System.Drawing.Imaging;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string[] lista = obtenerImagenes();
            using (DocX document = DocX.Create("prueba.docx"))
            {
                Paragraph paragraph = document.InsertParagraph();
                foreach(string imagen in lista)
                {
                    insertarImagen(document, imagen, 200);
                    agregarParrafo(document, imagen);
                }
                agregarEncabezado(document);
                salvarArchivo(document, "prueba.docx");
            }*/
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos ppf(.ppf)|*.ppf|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] fid = extraer.cargar(openFileDialog1.FileName);
                Extraer.extraerPlan(fid);
            }
        }
        private static DocX abrirArchivo(string pathAbrir)
        {
            using (DocX document = DocX.Load(pathAbrir))
                return document;
        }

               private static void salvarArchivo(DocX document, string pathGuardar)
        {
            document.Save();
        }

        private static string[] obtenerImagenes()
        {
             return Directory.GetFiles("E:\\PAblO\\Fotos", "*.jpg");
        }
        private static void insertarImagen(DocX document, string pathImagen, int tamaño)
        {
            double gantry = 30;
            double col = 20;
            string texto = "Gantry=" + gantry.ToString() + ", Col=" + col.ToString();
            var image = document.AddImage(pathImagen);
            var picture = image.CreatePicture();
            double relacionAspecto = Convert.ToDouble(picture.Width)/Convert.ToDouble(picture.Height);
            picture.Height= tamaño;
            picture.Width = Convert.ToInt32(tamaño * relacionAspecto);
            Paragraph paragraph = document.InsertParagraph();
            paragraph.AppendPicture(picture).InsertText(texto);
            paragraph.Alignment = Alignment.center;
        }
        private static void agregarEncabezado(DocX document)
        {
            document.AddHeaders();
            document.Headers.Even.InsertParagraph().Bold().Font("Arial").FontSize(18).InsertText("este es el encabezado EVEN");
            document.Headers.Odd.InsertParagraph().Bold().Font("Arial").FontSize(18).InsertText("este es el encabezado ODD");
            document.Headers.First.InsertParagraph().Bold().Font("Arial").FontSize(18).InsertText("este es el encabezado FIRST");
        }
    
        private static void agregarParrafo(DocX document,string texto)
        {
            document.InsertParagraph().Font("Calibri").FontSize(15).SpacingBefore(5).SpacingAfter(3).InsertText(texto);
        }
    }


    

}