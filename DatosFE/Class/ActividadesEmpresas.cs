using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    public class ActividadesEmpresas
    {
        private FEContext entities;

        public ActividadesEmpresas()
        {
            entities = new FEContext();
        }

        public int CrearActividadesEmpresas(EmpresaActividade empresa) // crear Actividades Empresas apartir de objeto de creacion
        {
            try
            {
                entities.EmpresaActividades.Add(empresa);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarActividadesEmpresas(int id) // borrar Empresa Actividades apartir del id Actividad


        {
            try
            {
                var p = entities.EmpresaActividades.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Models.ActividadEmpresa> ObtenerActividadesEmpresas(int emisor) //obtener lista Empresa Actividad
        {
            try
            {
                var temp = from ea in entities.EmpresaActividades
                           join a in entities.ActividadEmpresas on ea.IdActividad equals a.IdActividad
                           where ea.IdEmisor == emisor
                           select a;
                List<Models.ActividadEmpresa> result = temp.ToList<Models.ActividadEmpresa>();

                if (result.Count > 0)
                {                                       
                    return result;
                }
                else
                {
                    return  null;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public List<EmpresaActividade> ObtenerActividadesEmpresa(int emisor) //obtener lista Empresa Actividad
        //{
        //    try
        //    {
        //        var temp = from c in entities.EmpresaActividades
        //                   where c.IdEmisor == emisor
        //                   select c;
        //        List<EmpresaActividade> result = temp.ToList<EmpresaActividade>();

        //        if (result.Count > 0)
        //        {
        //            return result;
        //        }
        //        else
        //        {
        //            return result = null;
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public List<EmpresaActividade> ObtenerActividadesEmpresas( bool principal ) //obtener lista Empresa Actividad
        //{
        //    try
        //    {
        //        var temp = from c in entities.EmpresaActividades
        //                   where c.EsPrincipal == principal
        //                   select c;
        //        List<EmpresaActividade> result = temp.ToList<EmpresaActividade>();

        //        if (result.Count > 0)
        //        {
        //            return result;
        //        }
        //        else
        //        {
        //            return result = null;
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
    }
