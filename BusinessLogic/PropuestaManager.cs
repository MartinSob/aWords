using BusinessEntity;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using Persistence.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public static class PropuestaManager
    {
        static PropuestaDao dao = new PropuestaDao();

        static public List<UsuarioPropuesto> obtener(Sector sec, int cant, int nivel, Puesto puesto = null, bool esJefe = false, Emblema em = null, bool puestoFijo = true)
        {
            var usuarios = esJefe ? dao.obtenerParaJefe(sec, 6) : dao.obtenerParaPuesto(sec, puesto, 6, puestoFijo);

            // TODO: If list is empty search for other people?

            foreach (var usuarioPropuesto in usuarios.ToList())
            {
				if(sec.puestos.Where(o => (o.Value != null && o.Value.id == usuarioPropuesto.id)).Count() > 0)
				{
				    usuarios.RemoveAll(x => x.id == usuarioPropuesto.id);
				    continue;
				}

				usuarioPropuesto.porcentajeObjetivosCumplidos = System.Math.Round(calcularCumplidos(usuarioPropuesto), 2);

                usuarioPropuesto.promedioDeNivelObjetivosCumplidos = System.Math.Round(calcularCumplidosNivel(usuarioPropuesto), 2);

                usuarioPropuesto.promedioNivelReconocimiento = System.Math.Round(calcularNivelReconocimientos(usuarioPropuesto), 2);

                usuarioPropuesto.promedioReconocimientosDeSuperiores = System.Math.Round(calcularReconocimientosDeSuperiores(usuarioPropuesto), 2);

                usuarioPropuesto.cantidadReconocimientos = calcularCantidadReconocimientos(usuarioPropuesto);

                usuarioPropuesto.cantidadObjetivosNoCumplidos = calcularObjetivosNoCumplidos(usuarioPropuesto);

                if (em != null)
                {
                    usuarioPropuesto.emblemasRecibidos = calcularEmblemas(usuarioPropuesto, em);
                }

                calcularValorEstadistico(usuarioPropuesto, esJefe, puesto);
            }

            ordenarRank(usuarios, cant, nivel);

            return usuarios;
        }

        static public void proponerEquipo(Sector sec, int nivel, bool puestoFijo = true) {
            if (sec.jefe == null) {
                List<UsuarioPropuesto> newBossList = obtener(sec, 1, nivel, null, true, null, puestoFijo);

                if (newBossList.Count > 0) {
                    sec.jefe = newBossList[0];
                }
            }

            foreach (KeyValuePair<Puesto, Usuario> position in sec.puestos.ToList()) {
                if(position.Value == null) {
                    List<UsuarioPropuesto> newUserList = obtener(sec, 1, nivel, position.Key, false, null, puestoFijo);

                    if(newUserList.Count == 0) {
                        continue;
					}

                    Puesto newPuesto = PuestoManager.obtener(sec.puestos.FindAll(p => p.Key == position.Key && p.Value == null)[0].Key.id);

                    sec.puestos.Remove(sec.puestos.FindAll(p => p.Key == position.Key && p.Value == null)[0]);
                    sec.puestos.Add(new KeyValuePair<Puesto, Usuario>(newPuesto, newUserList[0]));
                }
			}
            
            return;
        }

        // Ordena la lista de usuarios por valorEstadistico, recorta a la cantidad, selcciona por nivel
        static public void ordenarRank(List<UsuarioPropuesto> us, int cant, int nivel)
        {
            us.Sort(delegate (UsuarioPropuesto x, UsuarioPropuesto y)
            {
                if (x.valorEstadistico == 0 && y.valorEstadistico == 0) return 0;
                else if (x.valorEstadistico == 0) return 1;
                else if (y.valorEstadistico == 0) return -1;
                else return x.valorEstadistico > y.valorEstadistico ? -1 : 1;
            });

            int first = nivel == 1 ? 0 : (nivel - 1) * cant;

            if (cant > us.Count) {
                cant = us.Count;
            }

            if (first + cant > us.Count) {
                first = us.Count - cant;
            }

            var result = us.GetRange(first, cant);
            us.Clear();

            foreach(UsuarioPropuesto up in result) {
                us.Add(up);
			}

            us = result;
        }

        // Devuelve un porcentaje de objetivos cumplidos
        static double calcularCumplidos(UsuarioPropuesto us)
        {
            var objetivosFinalizados = ObjetivoManager.obtenerFinalizados(us).Count;
            var objetivosCumplidos = ObjetivoManager.objetivosCumplidos(us).Count;

            return objetivosFinalizados > 0 ? (objetivosCumplidos * 100) / objetivosFinalizados : 0;
        }

        // Devuelve un porcentaje de objetivos cumplidos por nivel de objetivo
        static double calcularCumplidosNivel(UsuarioPropuesto us)
        {
            var objetivosCumplidos = ObjetivoManager.objetivosCumplidos(us);

            double sumNivel = 0;
            foreach (Objetivo objetivoCumplido in objetivosCumplidos)
            {
                sumNivel += objetivoCumplido.nivelIssue;
            }

            return objetivosCumplidos.Count > 0 ? (sumNivel / objetivosCumplidos.Count) : 0;
        }

        // Devuelve el promedio de niveles de los reconocimientos recibidos
        static double calcularNivelReconocimientos(UsuarioPropuesto us)
        {
            var reconocimientos = ReconocimientoManager.obtenerRecibidos(us);
            var sumNivel = 0;
            foreach (Reconocimiento reconocimiento in reconocimientos)
            {
                sumNivel += reconocimiento.valoracion;
            }
            return reconocimientos.Count > 0 ? sumNivel / reconocimientos.Count : 0;
        }

        // Devuelve el promedio del nivel de los reconocimientos recibidos de superiores durante los ultimos 3 meses
        static double calcularReconocimientosDeSuperiores(UsuarioPropuesto us)
        {
            var reconocimientos = ReconocimientoManager.obtenerRecibidosDeSuperiores(us);
            var sumNivel = 0;
            foreach (Reconocimiento reconocimiento in reconocimientos)
            {
                sumNivel += reconocimiento.valoracion;
            }
            return reconocimientos.Count > 0 ? sumNivel / reconocimientos.Count : 0;
        }

        // Devuelve la cantidad de objetivos no cumplidos en los ultimos 3 meses
        static int calcularObjetivosNoCumplidos(Usuario us)
        {
            return ObjetivoManager.ultimosObjetivosNoCumplidos(us).Count;
        }

        static int calcularCantidadReconocimientos(Usuario us)
        {
            return ReconocimientoManager.obtenerUltimosRecibidos(us).Count;
        }

        static int calcularEmblemas(Usuario us, Emblema em)
        {
            return EmblemaManager.obtener(us, em);
        }

        static public double calcularValorEstadistico(UsuarioPropuesto us, bool esJefe = false, Puesto puesto = null)
        {
            double valor = -(us.cantidadObjetivosNoCumplidos * 0.05);
            valor += us.cantidadReconocimientos * 0.1;
            
            if (esJefe)
            {
                valor += us.promedioReconocimientosDeSuperiores * 0.4;
                valor += us.porcentajeObjetivosCumplidos * 0.2;
                valor += us.promedioDeNivelObjetivosCumplidos * 0.2;
                valor += us.promedioNivelReconocimiento * 0.1;
            }
            else
            {
                valor += us.promedioReconocimientosDeSuperiores * 0.3;
                valor += us.porcentajeObjetivosCumplidos * 0.25;
                valor += us.promedioDeNivelObjetivosCumplidos * 0.25;
                valor += us.promedioNivelReconocimiento * 0.05;
            }

            if (us.emblemasRecibidos != 0) {
                valor += us.emblemasRecibidos * 0.3;
            }

            if (puesto != null && PuestoManager.obtener(us).id == puesto.id) {
                valor += 20;
			}

            us.valorEstadistico = System.Math.Round(valor, 2);

            return us.valorEstadistico;
        }
    
        static public string exportPDF(string filename) {
            List<UsuarioPropuesto> usuarios = obtener(new Sector() { id = 0 }, 20, 1, puestoFijo: false);

            PdfDocument document = new PdfDocument();
            document.Info.Title = "aWords";

            XFont fontTitle = new XFont("Verdana", 20, XFontStyle.Bold);
            XFont fontSubject = new XFont("Verdana", 12, XFontStyle.Italic);
            XFont fontBody = new XFont("Verdana", 14, XFontStyle.Regular);

            foreach (UsuarioPropuesto user in usuarios) {
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XTextFormatter tf = new XTextFormatter(gfx);
                XRect rect = new XRect(40, 40, page.Width, page.Height);

                tf.DrawString($"{user.apellido}, {user.nombre} ", fontTitle, XBrushes.Black, rect, XStringFormats.TopLeft);
                tf.DrawString($"{SectorManager.obtener(user).nombre} - {PuestoManager.obtener(user).nombre}", fontSubject, XBrushes.Black, 
                    new XRect(40, 65, page.Width, page.Height), XStringFormats.TopLeft);

				tf.DrawString($"Porcentaje objetivos cumplidos: {user.porcentajeObjetivosCumplidos} " +
                    $"\n" +
                    $"Promedio de nivel objetivos cumplidos: {user.promedioDeNivelObjetivosCumplidos}" +
                    $"\n" +
                    $"Cantidad objetivos no cumplidos: {user.cantidadObjetivosNoCumplidos}" +
                    $"\n" +
                    $"Promedio reconocimientos de superiores: {user.promedioReconocimientosDeSuperiores}" +
                    $"\n" +
                    $"Cantidad reconocimientos: {user.cantidadReconocimientos}" +
                    $"\n" +
                    $"Promedio nivel reconocimiento: {user.promedioNivelReconocimiento}" +
                    $"\n" +
                    $"Valor estadistico: {user.valorEstadistico}", fontBody, XBrushes.Black,
				   new XRect(40, 90, page.Width, page.Height), XStringFormats.TopLeft);
			}

            document.Save(filename);

            return filename;
        }
    }
}
