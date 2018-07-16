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


        private static List<string> imagenes(Paciente paciente)
        {
            return IO.obtenerImagenes(paciente.apellido);
        }

        public static int cantidadDeImagenes(Paciente paciente)
        {
            return imagenes(paciente).Count();
        }

        private static List<string> imagenesBEVCampos(Paciente paciente, int etapa)
        {
            return imagenes(paciente).GetRange(0, paciente.planes[etapa - 1].cantidadDeCampos);
        }
        private static List<string> imagenesBEVSetUp(Paciente paciente, int etapa, bool hayImagenesSetup)
        {
            return imagenes(paciente).GetRange(paciente.planes[etapa - 1].cantidadDeCampos, 2);
        }
        private static List<string> imagenesInforme(Paciente paciente, bool hayDosImagenes3D, bool hayImagenesSetup, bool imprimirBEV)
        {
            int cantidadCamposTotales = 0;
            if (imprimirBEV) //si son varias etapas no imprime BEV
            {
                cantidadCamposTotales += paciente.planes[0].cantidadDeCampos;//si son varias etapas no imprime BEV
                if (hayImagenesSetup)
                {
                    cantidadCamposTotales += 2;
                }
            }
            if (hayDosImagenes3D)
            {
                return imagenes(paciente).GetRange(cantidadCamposTotales, 6);
            }
            else
            {
                return imagenes(paciente).GetRange(cantidadCamposTotales, 5);
            }

        }


        private static void agregarParrafo(DocX document, string texto, Font fuente, int tamaño = 12)
        {
            document.InsertParagraph().InsertText(texto);
            document.Paragraphs.Last().Font(fuente).FontSize(tamaño);
        }

        private static void insertarImagen(DocX document, string pathImagen, double tamaño, Alignment alineacion, string textoExtra = "")
        {
            var image = document.AddImage(pathImagen);
            var picture = image.CreatePicture();
            double relacionAspecto = Convert.ToDouble(picture.Width) / Convert.ToDouble(picture.Height);
            picture.Height = Convert.ToInt32(tamaño * RelPtaCm);
            picture.Height = Convert.ToInt32(tamaño * RelPtaCm);
            picture.Height = Convert.ToInt32(tamaño * RelPtaCm);
            picture.Height = Convert.ToInt32(tamaño * RelPtaCm);
            picture.Height = Convert.ToInt32(tamaño * RelPtaCm);
            picture.Height = Convert.ToInt32(tamaño * RelPtaCm);
            picture.Width = Convert.ToInt32(tamaño * relacionAspecto * RelPtaCm);
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

        private static void encabezadoBEV(Paciente paciente, int etapa, DocX document)
        {
            document.AddHeaders();
            agregarEncabezado(document, Textos.encabezadoBEV1(paciente), FuenteTexto, 12, Alignment.left);
            agregarEncabezado(document, Textos.encabezadoBEV2(paciente,etapa), FuenteTexto, 12, Alignment.center);
        }

        private static void profundidadesEfectivasBEV(DocX document, string textoCrudo)
        {
            if (textoCrudo != null || textoCrudo != "")
            {
                agregarParrafo(document, Textos.profundidadesEfectivas(textoCrudo), FuenteTexto);
            }
        }

        private static void imagenesBEV(Paciente paciente, int etapa, DocX document, string gantrySetUp1, string tamSetUp1, string gantrySetUp2, string tamSetUp2, bool hayImagenesSetup)
        {
            if (hayImagenesSetup)
            {
                insertarImagen(document, imagenesBEVSetUp(paciente, etapa, hayImagenesSetup)[0], 11, Alignment.left, Textos.parametrosCampoSetUp(gantrySetUp1, tamSetUp1));
                insertarImagen(document, imagenesBEVSetUp(paciente, etapa, hayImagenesSetup)[1], 11, Alignment.left, Textos.parametrosCampoSetUp(gantrySetUp2, tamSetUp2));
            }

            for (int i = 0; i < paciente.planes[etapa - 1].cantidadDeCampos; i++)
            {
                insertarImagen(document, imagenesBEVCampos(paciente,etapa)[i], 11, Alignment.left, Textos.parametrosCampoTto(paciente.planes[etapa - 1].listaCampos[i]));
            }
        }


        public static void crearArchivoBEV(Paciente paciente, int etapa, bool hayImagenesSetup, string SetUp1Gantry, string SetUp2Gantry, string SetUp1Tam, string SetUp2Tam, string textoCrudo)
        {
            DocX document = DocX.Create("BEV.doc");
            document.DifferentFirstPage = false;
            document.DifferentFirstPage = false; //para que todos los encabezados sean iguales
            document.MarginTop = Convert.ToInt32(1.41 * RelPtaCm * factor);
            document.MarginBottom = Convert.ToInt32(0.95 * RelPtaCm * factor);
            document.MarginLeft = Convert.ToInt32(0.95 * RelPtaCm * factor);
            document.MarginRight = Convert.ToInt32(0.95 * RelPtaCm * factor);
            encabezadoBEV(paciente,etapa, document);
            imagenesBEV(paciente, etapa, document, SetUp1Gantry, SetUp1Tam, SetUp2Gantry, SetUp2Tam, hayImagenesSetup);
            agregarParrafo(document, "", FuenteTexto);
            profundidadesEfectivasBEV(document, textoCrudo);
            string aux = IO.pathDestino + paciente.apellidoNombre + " " + paciente.ID;
            if (paciente.numeroDeEtapas==1)
            {
                aux += "\\BEV.doc";
            }
            else
            {
                aux += "\\Etapa " + etapa.ToString() + "\\BEV.doc";
            }
            salvarArchivo(document, aux);
        }

        private static void encabezadoInforme(Paciente paciente, DocX document)
        {
            document.AddHeaders();
            agregarEncabezadoNegrita(document, Textos.encabezadoInformeLinea1(paciente), FuenteTexto, 14, Alignment.left);
            agregarEncabezado(document, Textos.encabezadoInformeLinea2(paciente), FuenteTexto, 12, Alignment.left);
            agregarEncabezado(document, Textos.encabezadoInformeLinea3(paciente), FuenteTexto, 12, Alignment.center);
        }

        private static void textoEImagenesInforme(Paciente paciente, DocX document, bool hayDosImagenes3D, bool hayImagenesSetUp, bool imprimirBEV)
        {
            insertarImagen(document, imagenesInforme(paciente, hayDosImagenes3D, hayImagenesSetUp, imprimirBEV)[0], 11, Alignment.center);
            agregarParrafo(document, Textos.axialInforme(paciente), FuenteTexto);
            insertarDosImagenes(document, imagenesInforme(paciente, hayDosImagenes3D, hayImagenesSetUp, imprimirBEV)[1], imagenesInforme(paciente, hayDosImagenes3D, hayImagenesSetUp, imprimirBEV)[2], 8, Alignment.center);
            agregarParrafo(document, Textos.coronalSagitalInforme(), FuenteTexto);
            if (hayDosImagenes3D)
            {
                insertarDosImagenes(document, imagenesInforme(paciente, hayDosImagenes3D, hayImagenesSetUp, imprimirBEV)[3], imagenesInforme(paciente, hayDosImagenes3D, hayImagenesSetUp, imprimirBEV)[4], 8, Alignment.center);
                agregarParrafo(document, Textos.tresDInforme(hayDosImagenes3D), FuenteTexto);
                insertarImagen(document, imagenesInforme(paciente, hayDosImagenes3D, hayImagenesSetUp, imprimirBEV)[5], 11, Alignment.center);
                agregarParrafo(document, Textos.dvhInforme(), FuenteTexto);
            }
            else
            {
                insertarImagen(document, imagenesInforme(paciente, hayDosImagenes3D, hayImagenesSetUp, imprimirBEV)[3], 11, Alignment.center);
                agregarParrafo(document, Textos.tresDInforme(hayDosImagenes3D), FuenteTexto);
                insertarImagen(document, imagenesInforme(paciente, hayDosImagenes3D, hayImagenesSetUp, imprimirBEV)[4], 11, Alignment.center);
                agregarParrafo(document, Textos.dvhInforme(), FuenteTexto);
            }

        }
        public static void crearArchivoInforme(Paciente paciente, bool hayDosImagenes3D, bool hayImagenesSetUp, bool imprimirBEV)
        {
            DocX document = DocX.Create("Informe.doc");
            document.DifferentFirstPage = false;
            document.DifferentFirstPage = false; //para que todos los encabezados sean iguales
            document.MarginTop = Convert.ToInt32(1.56 * RelPtaCm * factor);
            document.MarginBottom = Convert.ToInt32(1.9 * RelPtaCm * factor);
            document.MarginLeft = Convert.ToInt32(0.63 * RelPtaCm * factor);
            document.MarginRight = Convert.ToInt32(0.68 * RelPtaCm * factor);
            encabezadoInforme(paciente, document);
            textoEImagenesInforme(paciente, document, hayDosImagenes3D, hayImagenesSetUp, imprimirBEV);
            string aux = IO.pathDestino + paciente.apellidoNombre + " " + paciente.ID + "\\Informe.doc";
            salvarArchivo(document, aux);
        }

    }
}
