using Microsoft.FlightSimulator.SimConnect;
using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace WinFormsAppServerFS
{
    partial class Form1
    {
         private void initSimEvents()
         {
            const int WM_USER_SIMCONNECT = 0x402;
            try
            {
                simconnect = new SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null, 0);
                System.Diagnostics.Debug.WriteLine("Connected To Microsoft Flight Simulator 2020!");

            }
            catch (COMException exception1)
            {
                System.Diagnostics.Debug.WriteLine(exception1);
                return;
            }
            simconnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(simconnect_OnRecvOpen);
            simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(simconnect_OnRecvQuit);
            simconnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(simconnect_OnRecvException);


            simconnect.AddToDataDefinition(DEFINITIONS.Def_RPOS, "heading indicator", "degrees", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(DEFINITIONS.Def_RPOS, "Indicated Altitude", "feet", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(DEFINITIONS.Def_RPOS, "Radio Height", "feet", SIMCONNECT_DATATYPE.FLOAT32, 0, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(DEFINITIONS.Def_RPOS, "attitude indicator bank degrees", "degrees", SIMCONNECT_DATATYPE.FLOAT32, 0, SimConnect.SIMCONNECT_UNUSED);

            simconnect.AddToDataDefinition(DEFINITIONS.Def_RREF, "Airspeed Indicated", "knots", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(DEFINITIONS.Def_RREF, "General Eng RPM:1", "Rpm", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.AddToDataDefinition(DEFINITIONS.Def_POS, "Kohlsman setting hg", "inHg", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(DEFINITIONS.Def_POS, "plane Altitude", "feet", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(DEFINITIONS.Def_POS, "Plane Latitude", "degrees", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(DEFINITIONS.Def_POS, "Plane Longitude", "degrees", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(DEFINITIONS.Def_POS, "Plane Bank Degrees", "degrees", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(DEFINITIONS.Def_POS, "Plane Pitch Degrees", "degrees", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(DEFINITIONS.Def_POS, "Plane Heading Degrees magnetic", "degrees", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(DEFINITIONS.Def_POS, "Airspeed Indicated", "knots", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.AddToDataDefinition(DEFINITIONS.Def_CONTROLS, "Rudder Position", "Position", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.AddToDataDefinition(DEFINITIONS.Def_TURN, "Incidence Beta", "degrees", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);



            System.Diagnostics.Debug.WriteLine("data added");

            simconnect.RegisterDataDefineStruct<RPOS_struct>(DEFINITIONS.Def_RPOS);
            simconnect.RegisterDataDefineStruct<RREF_struct>(DEFINITIONS.Def_RREF);
            simconnect.RegisterDataDefineStruct<POS_struct>(DEFINITIONS.Def_POS);
            simconnect.RegisterDataDefineStruct<CONTROLS_struct>(DEFINITIONS.Def_CONTROLS);
            simconnect.RegisterDataDefineStruct<TURN_struct>(DEFINITIONS.Def_TURN);


            simconnect.OnRecvSimobjectData += new SimConnect.RecvSimobjectDataEventHandler(simconnect_OnRecvSimobjectData);

            simconnect.RequestDataOnSimObject(REQUESTS.REQ_RPOS, DEFINITIONS.Def_RPOS, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_PERIOD.VISUAL_FRAME, SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT,0,0,0);
            simconnect.RequestDataOnSimObject(REQUESTS.REQ_RREF, DEFINITIONS.Def_RREF, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_PERIOD.VISUAL_FRAME, SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT, 0, 0, 0);
            simconnect.RequestDataOnSimObject(REQUESTS.REQ_CONTROLS, DEFINITIONS.Def_CONTROLS, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_PERIOD.VISUAL_FRAME, SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT, 0, 0, 0);
            simconnect.RequestDataOnSimObject(REQUESTS.REQ_TURN, DEFINITIONS.Def_TURN, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_PERIOD.VISUAL_FRAME, SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT, 0, 0, 0);


            System.Diagnostics.Debug.WriteLine("request done");

       //     simconnect.RequestDataOnSimObjectType(REQUESTS.REQ_RPOS, DEFINITIONS.Def_RPOS, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
          
         }

        private void simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            System.Diagnostics.Debug.WriteLine("quitting simco");
            pictureBoxSimCo.Image = global::WinFormsAppServerFS.Properties.Resources.redDot;
        }

        private void simconnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            System.Diagnostics.Debug.WriteLine("opening simco");
            pictureBoxSimCo.Image = global::WinFormsAppServerFS.Properties.Resources.greenDot;

        }

        private void simconnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            System.Diagnostics.Debug.WriteLine("exception appear");
            System.Diagnostics.Debug.WriteLine(data);

        }

        private void simconnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
        {
            switch ((REQUESTS)data.dwRequestID)
            {
                case REQUESTS.REQ_RPOS:
                    RPOS_struct provi = (RPOS_struct)data.dwData[0];
                    RPOS_STR = "0;" + String.Format(CultureInfo.InvariantCulture, "{0:F1}", provi.heading) + ";" + String.Format(CultureInfo.InvariantCulture, "{0:F1}", provi.altitude) + ";" + String.Format(CultureInfo.InvariantCulture, "{0:F1}", provi.radioHeight) + ";" + String.Format(CultureInfo.InvariantCulture, "{0:F1}", provi.bank);
                    RPOSField.Text = RPOS_STR;
                    break;

                case REQUESTS.REQ_RREF:
                    RREF_struct provi2 = (RREF_struct)data.dwData[0];
                    RREF_STR = "1;" + String.Format(CultureInfo.InvariantCulture, "{0:F1}",provi2.speed) + ";" + String.Format(CultureInfo.InvariantCulture, "{0:F1}", provi2.rpm);
                    RREFField.Text = RREF_STR;
                    break;
                case REQUESTS.REQ_CONTROLS:
                    CONTROLS_struct provi3 = (CONTROLS_struct)data.dwData[0];
                    rudder_val = provi3.rudder;
                    try
                    {
                        fc.SetRudderValue(rudder_val);
                    }
                    catch (Exception ex)
                    {
                    }
                    break;
                case REQUESTS.REQ_TURN:
                    TURN_struct provi4 = (TURN_struct)data.dwData[0];
                    sideslip_val = provi4.sideslip;
                    try
                    {
                        fc.SetSideSlipValue(sideslip_val);
                    }
                    catch (Exception ex)
                    {
                    }
                    break;
                default:
                    System.Diagnostics.Debug.WriteLine("message non reconnu");
                    break;
            }
        }
        private void simconnect_parser(string strings)
        {
            var splitted = strings.Split(';');
            switch ((COMMAND)int.Parse(splitted[0]))
            {
                case COMMAND.TP_REQ:
                    POS_struct pos_struct = new POS_struct();
                    pos_struct.kohlsman = 29.92f;
                    pos_struct.altitude = (float)double.Parse(splitted[3], CultureInfo.InvariantCulture);
                    pos_struct.latitude = (float)double.Parse(splitted[1], CultureInfo.InvariantCulture);
                    pos_struct.longitude = (float)double.Parse(splitted[2], CultureInfo.InvariantCulture);
                    pos_struct.roll = 0f;
                    pos_struct.pitch = 0f;
                    pos_struct.heading = 0f;
                    pos_struct.speed = (float)double.Parse(splitted[4], CultureInfo.InvariantCulture);
                    System.Diagnostics.Debug.WriteLine("received message parsed : "+ pos_struct.latitude +"   "+ pos_struct.longitude+"   "+ pos_struct.speed);

                    simconnect.SetDataOnSimObject(DEFINITIONS.Def_POS, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_DATA_SET_FLAG.DEFAULT, pos_struct);
                    break;
                default:
                    System.Diagnostics.Debug.WriteLine("received message not recognised");
                    break;


            }
        }
    }

}
