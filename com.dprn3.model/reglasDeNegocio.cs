using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.model
{
    class reglasDeNegocio
    {


        //Se valida si el empleado puede ser asignado a un proyecto
        public static void ValidacionAsignacionEmpleadoProyecto()
        {
            //clsAltaInformacion perfilDesarrollador = new clsAltaInformacion();

            for (int i = 0; i < clsAltaInformacion.contarTotalRegistrosEmpleadosAsignados(); i++)
            {
                //Se valida el proyecto
                if (ValidaciónIngresoNuevoProyecto() == true)
                {

                    if (clsAltaInformacion.ubicaEmpleado() == false)
                    {
                        //Verifica si el empleado es Programador
                        Boolean isProgrammer = clsAltaInformacion.ValidaSiesRolDeProgramador();
                        if (isProgrammer.Equals(true))
                        {
                            clsAltaInformacion validaLimiteDesarrollador = new clsAltaInformacion();
                            int limiteP = validaLimiteDesarrollador.MatrixToFilterProgrammersOnly();

                            if (limiteP == 3)
                            {
                                //Arroja mensaje de restriccion a ingreso por exceder el maximo de desarrolladores
                                Notificacion mensaje2 = new Notificacion(new NotificacionFalloProgramador());
                                mensaje2.MostrarMensaje();
                                break;
                            }
                            else
                            {
                                //Si aun hay cupo para un desarrollador lo inserta y sale del bucle
                                clsAltaInformacion.insertarDatosNuevaAsignacionAProyecto(frmAsignacionProyectos.noEmpleado, frmAsignacionProyectos.idProyecto, frmAsignacionProyectos.asignacionEmpleado, frmAsignacionProyectos.comentarios);
                                break;

                            }
                        }

                        //Verifica si el empleado es Lider De Proyecto
                        Boolean isTechLeader = clsAltaInformacion.ValidaSiesRolDeLiderDeProyecto();
                        if (isTechLeader.Equals(true))
                        {
                            clsAltaInformacion validaLimiteTL = new clsAltaInformacion();
                            int limiteTL = validaLimiteTL.MatrixToFilterProjectLeadersOnly();

                            if (limiteTL == 1)
                            {
                                //Arroja mensaje de restriccion a ingreso por exceder el maximo de desarrolladores
                                Notificacion mensaje2 = new Notificacion(new NotificacionFallo());
                                mensaje2.MostrarMensaje();
                                break;
                            }
                            else
                            {
                                //Si aun hay cupo para un desarrollador lo inserta y sale del bucle
                                clsAltaInformacion.insertarDatosNuevaAsignacionAProyecto(frmAsignacionProyectos.noEmpleado, frmAsignacionProyectos.idProyecto, frmAsignacionProyectos.asignacionEmpleado, frmAsignacionProyectos.comentarios);
                                break;

                            }
                        }

                        //Verifica si el empleado es Analista
                        Boolean isAnalista = clsAltaInformacion.ValidaSiesRolDeAnalista();
                        if (isAnalista.Equals(true))
                        {
                            clsAltaInformacion validaLimiteTL = new clsAltaInformacion();
                            int limiteTL = validaLimiteTL.MatrixToFilterAnalystOnly();

                            if (limiteTL == 1)
                            {
                                //Arroja mensaje de restriccion a ingreso por exceder el maximo de Analistas
                                Notificacion mensaje2 = new Notificacion(new NotificacionFalloAnalistas());
                                mensaje2.MostrarMensaje();
                                break;
                            }
                            else
                            {
                                //Si aun hay cupo para un analista lo inserta y sale del bucle
                                clsAltaInformacion.insertarDatosNuevaAsignacionAProyecto(frmAsignacionProyectos.noEmpleado, frmAsignacionProyectos.idProyecto, frmAsignacionProyectos.asignacionEmpleado, frmAsignacionProyectos.comentarios);
                                break;

                            }
                        }
                    }

                    //Si el status del empleado es 0
                    if (clsAltaInformacion.isAssigned() != 1)
                    {
                        //Verifica si el empleado es Programador
                        Boolean isProgrammer = clsAltaInformacion.ValidaSiesRolDeProgramador();
                        if (isProgrammer.Equals(true))
                        {
                            clsAltaInformacion validaLimiteDesarrollador = new clsAltaInformacion();
                            int limiteP = validaLimiteDesarrollador.MatrixToFilterProgrammersOnly();

                            if (limiteP == 3)
                            {
                                //Arroja mensaje de restriccion a ingreso por exceder el maximo de desarrolladores
                                Notificacion mensaje2 = new Notificacion(new NotificacionFalloProgramador());
                                mensaje2.MostrarMensaje();
                                break;
                            }
                            else
                            {
                                //Si aun hay cupo para un desarrollador lo inserta y sale del bucle
                                clsAltaInformacion.actualizaInformaciónProyecto();
                                break;
                            }
                        }

                        //Verifica si el empleado es Lider De Proyecto
                        Boolean isTechLeader = clsAltaInformacion.ValidaSiesRolDeLiderDeProyecto();
                        if (isTechLeader.Equals(true))
                        {
                            clsAltaInformacion validaLimiteTL = new clsAltaInformacion();
                            int limiteTL = validaLimiteTL.MatrixToFilterProjectLeadersOnly();

                            if (limiteTL == 1)
                            {
                                //Arroja mensaje de restriccion a ingreso por exceder el maximo de desarrolladores
                                Notificacion mensaje2 = new Notificacion(new NotificacionFallo());
                                mensaje2.MostrarMensaje();
                                break;
                            }
                            else
                            {
                                //Si aun hay cupo para un lider de proyecto lo inserta y sale del bucle
                                clsAltaInformacion.actualizaInformaciónProyecto();
                                break;

                            }
                        }

                        //Verifica si el empleado es Analista
                        Boolean isAnalista = clsAltaInformacion.ValidaSiesRolDeAnalista();
                        if (isAnalista.Equals(true))
                        {
                            clsAltaInformacion validaLimiteTL = new clsAltaInformacion();
                            int limiteTL = validaLimiteTL.MatrixToFilterAnalystOnly();

                            if (limiteTL == 1)
                            {
                                //Arroja mensaje de restriccion a ingreso por exceder el maximo de Analistas
                                Notificacion mensaje2 = new Notificacion(new NotificacionFalloAnalistas());
                                mensaje2.MostrarMensaje();
                                break;
                            }
                            else
                            {
                                //Si aun hay cupo para un analista lo inserta y sale del bucle
                                clsAltaInformacion.actualizaInformaciónProyecto();
                                break;

                            }
                        }
                    }

                  
                       /*//Se valida si se sacara a este empleado del proyecto actual
                        if (clsAltaInformacion.isAssigned() == 1 && frmAsignacionProyectos.isAsignacion == 0)
                        {
                            clsAltaInformacion.actualizaInformaciónProyecto();
                            //Arroja mensaje de restriccion a ingreso por exceder el maximo de desarrolladores
                            Notificacion mensajeOffProject = new Notificacion(new NotificacionFueraDeProyecto());
                            mensajeOffProject.MostrarMensaje();
                            break;
                        }*/
                    

                    if (clsAltaInformacion.isAssigned() == 1)
                    {
                        //Arroja mensaje de restriccion a ingreso por exceder el maximo de desarrolladores
                        Notificacion excedePosicion = new Notificacion(new NotificacionExcedeNumeroEmpleados());
                        excedePosicion.MostrarMensaje();
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        //Se valida si el proyecto esta disponible o no esta disponible
        public static Boolean ValidaciónIngresoNuevoProyecto()
        {
            string fechaFinalProyecto = clsAltaInformacion.fechaFinalExist();

            if (!fechaFinalProyecto.Equals(""))
            {
                MessageBox.Show("El proyecto ya ha sido concluido, puesto que hay fecha de terminación.");
                return false;
            }

            return true;
        }


    }
}
