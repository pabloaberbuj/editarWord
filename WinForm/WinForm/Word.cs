using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xceed.Words.NET;

namespace WinForm
{
    class Word
    {
        private static readonly double RelPtaCm = 37.8;
        private static readonly double factor = 0.75; //para que den los margenes
        private static Font FuenteTexto = new Font("Times New Roman");

        
        private static List<string> imagenes(Plan plan)
        {
            return IO.obtenerImagenes(plan.apellido);
        }

        public static int cantidadDeImagenes(Plan plan)
        {
            return imagenes(plan).Count();
        }

        private static List<string> imagenesBEVCampos(Plan plan)
        {
            return imagenes(plan).GetRange(0, plan.cantidadDeCampos);
        }
        private static List<string> imagenesBEVSetUp(Plan plan, bool hayImagenesSetup)
        {
            return imagenes(plan).GetRange(plan.cantidadDeCampos, 2);
        }
        private static List<string> imagenesInforme(Plan plan, bool hayDosImagenes3D, bool hayImagenesSetup)
        {
            int cantidadCamposTotales = plan.cantidadDeCampos;
            if(hayImagenesSetup)
            {
                cantidadCamposTotales += 2;
            }
            if (hayDosImagenes3D)
            {
                return imagenes(plan).GetRange(cantidadCamposTotales, 6);
            }
            else
            {
                return imagenes(plan).GetRange(cantidadCamposTotales, 5);
            }
        }
        
        private static void agregarParrafo(DocX document, string texto, Font fuente, int tamaño=12)
        {
            document.InsertParagraph().InsertText(texto);
            document.Paragraphs.Last().Font(fuente).FontSize(tamaño);
        }

        private static void insertarImagen(DocX document, string pathImagen, double tamaño, Alignment alineacion, string textoExtra = "")
        {
            var image = document.AddImage(pathImagen);
            var picture = image.CreatePicture();
            double relacionAspecto = Convert.ToDouble(picture.Width) / Convert.ToDouble(picture.Height);
            picture.Height = Convert.ToInt32(tamaño*RelPtaCm);
            picture.Width = Convert.ToInt32(tamaño * relacionAspecto* RelPtaCm);
            Paragraph paragraph = document.InsertParagraph();
            paragraph.AppendPicture(picture);
            paragraph.Append(textoExtra);
            paragraph.Font(FuenteTexto).FontSize(12);
            paragraph.Alignment = alineacion;
        }

        private static void insertarDosImagenes(DocX document, string pathImagen1, string pathImagen2, double tamaño, Alignment alineacion)
        {
            var image1 = document.AddImage(pathImagen1);
            var image2 = document.AddImage(pathImagen2);
            var picture1 = image1.CreatePicture();
            var picture2 = image2.CreatePicture();
            double relacionAspecto = Convert.ToDouble(picture1.Width) / Convert.ToDouble(picture1.Height);
            picture1.Height = Convert.ToInt32(tamaño * RelPtaCm);
            picture2.Height = picture1.Height;
            picture1.Width = Convert.ToInt32(tamaño * relacionAspecto * RelPtaCm);
            picture2.Width = picture1.Width;
            Paragraph paragraph = document.InsertParagraph();
            paragraph.AppendPicture(picture1).AppendPicture(picture2);
            paragraph.Alignment = alineacion;
        }

        private static void agregarEncabezado(DocX document, string texto, Font fuente, int tamaño, Alignment alineacion)
        {
            document.Headers.Odd.InsertParagraph().Append(texto).Alignment = alineacion;
            document.Headers.Odd.Paragraphs.Last().Font(fuente).FontSize(tamaño);
        }

        private static void agregarEncabezadoNegrita(DocX document, string texto, Font fuente, int tamaño, Alignment alineacion)
        {
            document.Headers.Odd.InsertParagraph().Append(texto).Alignment = alineacion;
            document.Headers.Odd.Paragraphs.Last().Font(fuente).FontSize(tamaño).Bold();

        }

        private static void salvarArchivo(DocX document, string pathGuardar)
        {
            try
            {
                document.SaveAs(pathGuardar);
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede guardar. Es posible que alguno de los documentos esté abierto");
                //throw;
            }
            
        }

        private static void encabezadoBEV(Plan plan, DocX document)
        {
            document.AddHeaders();
            agregarEncabezado(document, Textos.encabezadoBEV1(plan), FuenteTexto, 12, Alignment.left);
            agregarEncabezado(document, Textos.encabezadoBEV2(plan), FuenteTexto, 12, Alignment.center);
        }

        private static void imagenesBEV(Plan plan, DocX document, string gantrySetUp1, string tamSetUp1, string gantrySetUp2, string tamSetUp2, bool hayImagenesSetup)
        {
            if (hayImagenesSetup)
            {
                insertarImagen(document, imagenesBEVSetUp(plan, hayImagenesSetup)[0], 11, Alignment.left, Textos.parametrosCampoSetUp(gantrySetUp1, tamSetUp1));
                insertarImagen(document, imagenesBEVSetUp(plan, hayImagenesSetup)[1], 11, Alignment.left, Textos.parametrosCampoSetUp(gantrySetUp2, tamSetUp2));
            }
            
            for (int i=0;i<plan.cantidadDeCampos;i++)
            {
                insertarImagen(document, imagenesBEVCampos(plan)[i], 11, Alignment.left, Textos.parametrosCampoTto(plan.listaCampos[i]));
            }
        }

        
        public static void crearArchivoBEV(Plan plan,bool hayImagenesSetup, string SetUp1Gantry, string SetUp2Gantry, string SetUp1Tam, string SetUp2Tam)
        {
            DocX document = DocX.Create("BEV.doc");
            document.DifferentFirstPage = false;
            document.DifferentFirstPage = false; //para que todos los encabezados sean iguales
            document.MarginTop = Convert.ToInt32(1.41* RelPtaCm*factor);
            document.MarginBottom = Convert.ToInt32(0.95* RelPtaCm * factor);
            document.MarginLeft = Convert.ToInt32(0.95* RelPtaCm * factor);
            document.MarginRight = Convert.ToInt32(0.95* RelPtaCm * factor);
            encabezadoBEV(plan, document);
            imagenesBEV(plan, document,SetUp1Gantry,SetUp1Tam,SetUp2Gantry,SetUp2Tam,hayImagenesSetup);
            string aux = IO.pathDestino + plan.apellidoNombre + " " + plan.ID + "\\BEV.doc";
            salvarArchivo(document, aux);
        }

        private static void encabezadoInforme(Plan plan, DocX document)
        {
            document.AddHeaders();
            agregarEncabezadoNegrita(document, Textos.encabezadoInformeLinea1(plan), FuenteTexto, 14, Alignment.left);
            agregarEncabezado(document, Textos.encabezadoInformeLinea2(plan), FuenteTexto, 12, Alignment.left);
            agregarEncabezado(document, Textos.encabezadoInformeLinea3(plan), FuenteTexto, 12, Alignment.center);
        }

        private static void textoEImagenesInforme(Plan plan, DocX document, bool hayDosImagenes3D,bool hayImagenesSetUp)
        {
            insertarImagen(document, imagenesInforme(plan,hayDosImagenes3D, hayImagenesSetUp)[0], 11, Alignment.center);
            agregarParrafo(document, Textos.axialInforme(plan), FuenteTexto);
            insertarDosImagenes(document, imagenesInforme(plan, hayDosImagenes3D, hayImagenesSetUp)[1], imagenesInforme(plan, hayDosImagenes3D, hayImagenesSetUp)[2], 8, Alignment.center);
            agregarParrafo(document, Textos.coronalSagitalInforme(), FuenteTexto);
            if (hayDosImagenes3D)
            {
                insertarDosImagenes(document, imagenesInforme(plan, hayDosImagenes3D, hayImagenesSetUp)[3], imagenesInforme(plan, hayDosImagenes3D, hayImagenesSetUp)[4], 8, Alignment.center);
                agregarParrafo(document, Textos.tresDInforme(hayDosImagenes3D), FuenteTexto);
                insertarImagen(document, imagenesInforme(plan, hayDosImagenes3D, hayImagenesSetUp)[5], 11, Alignment.center);
                agregarParrafo(document, Textos.dvhInforme(plan), FuenteTexto);
            }
            else
            {
                insertarImagen(document, imagenesInforme(plan, hayDosImagenes3D, hayImagenesSetUp)[3], 11, Alignment.center);
                agregarParrafo(document, Textos.tresDInforme(hayDosImagenes3D), FuenteTexto);
                insertarImagen(document, imagenesInforme(plan, hayDosImagenes3D, hayImagenesSetUp)[4], 11, Alignment.center);
                agregarParrafo(document, Textos.dvhInforme(plan), FuenteTexto);
            }
            
        }
        public static void crearArchivoInforme(Plan plan, bool hayDosImagenes3D,bool hayImagenesSetUp)
        {
            DocX document = DocX.Create("Informe.doc");
            document.DifferentFirstPage = false;
            document.DifferentFirstPage = false; //para que todos los encabezados sean iguales
            document.MarginTop = Convert.ToInt32(1.56 * RelPtaCm * factor);
            document.MarginBottom = Convert.ToInt32(1.9 * RelPtaCm * factor);
            document.MarginLeft = Convert.ToInt32(0.63 * RelPtaCm * factor);
            document.MarginRight = Convert.ToInt32(0.68 * RelPtaCm * factor);
            encabezadoInforme(plan,document);
            textoEImagenesInforme(plan, document,hayDosImagenes3D, hayImagenesSetUp);
            string aux = IO.pathDestino + plan.apellidoNombre + " " + plan.ID + "\\Informe.doc";
            salvarArchivo(document, aux);
        }
       
    }
}
