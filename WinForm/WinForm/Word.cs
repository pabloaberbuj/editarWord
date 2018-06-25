using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xceed.Words.NET;

namespace WinForm
{
    class Word
    {
        private static readonly double RelPtaCm = 40;

        private static void agregarParrafo(DocX document, string texto, Font fuente, int tamaño)
        {
            document.InsertParagraph().Font(fuente).FontSize(tamaño).InsertText(texto);
        }

        private static void insertarImagen(DocX document, string pathImagen, int tamaño, Alignment alineacion, string textoExtra = "")
        {
            var image = document.AddImage(pathImagen);
            var picture = image.CreatePicture();
            double relacionAspecto = Convert.ToDouble(picture.Width) / Convert.ToDouble(picture.Height);
            picture.Height = Convert.ToInt32(tamaño*RelPtaCm);
            picture.Width = Convert.ToInt32(tamaño * relacionAspecto* RelPtaCm);
            Paragraph paragraph = document.InsertParagraph();
            paragraph.AppendPicture(picture);
            paragraph.InsertText(textoExtra);
            paragraph.Alignment = alineacion;
        }
        private static void agregarEncabezado(DocX document, string texto, Font fuente, int tamaño)
        {
            document.AddHeaders();
            document.Headers.Even.InsertParagraph().Font(fuente).FontSize(tamaño).InsertText(texto);
            document.Headers.Odd.InsertParagraph().Font(fuente).FontSize(tamaño).InsertText(texto);
            document.Headers.First.InsertParagraph().Font(fuente).FontSize(tamaño).InsertText(texto);
        }

        private static void salvarArchivo(DocX document, string pathGuardar)
        {
            document.SaveAs(pathGuardar);
        }

        private static void encabezadoBEV(Plan plan, DocX document)
        {
            agregarEncabezado(document, Textos.encabezadoBEV(plan),new Font("Times New Roman") , 12);
        }

        private static void imagenesBEV(Plan plan, DocX document)
        {
            List<string> imagenes = IO.obtenerImagenes(plan.nombre);
            for (int i=0;i<plan.cantidadDeCampos;i++)
            {
                insertarImagen(document, imagenes[i], 11, Alignment.left, Textos.parametrosCampoTto(plan.listaCampos[i]));
            }

        }

        
        public static void crearArchivoBEV(Plan plan)
        {
            DocX document = DocX.Create("BEV.doc");
            encabezadoBEV(plan, document);
            imagenesBEV(plan, document);
            string aux = IO.pathDestino + plan.nombre[0] + ", " + plan.nombre[1] + " " + plan.ID + "\\BEV.doc";
            salvarArchivo(document, aux);
        }

       
    }
}
