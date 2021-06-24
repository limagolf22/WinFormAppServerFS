using System.Runtime.InteropServices;

namespace WinFormsAppServerFS
{
    public enum COMMAND
    {
        ADD_REQ,
        ADD_VAL_DEF,
        DEF_REQ,
        TP_REQ
    }
    
    public enum DEFINITIONS
    {
        Def_RPOS,
        Def_RREF,
        Def_POS,
        Def_CONTROLS,
        Def_TURN
    }

    public enum REQUESTS
    {
        REQ_RPOS,
        REQ_RREF,
        REQ_CONTROLS,
        REQ_TURN
    }

    public enum EVENTS
    {
        TXT_EVENT
    }
    public struct RPOS_struct
    {
        public float heading;
        public float altitude;
        public float radioHeight;
        public float bank;
    };

    public struct RREF_struct
    {
        public float speed;
        public float rpm;
    };
    public struct POS_struct
    {
        public float kohlsman;
        public float altitude;
        public float latitude;
        public float longitude;
        public float roll;
        public float pitch;
        public float heading;
        public float speed;
    };
    public struct CONTROLS_struct
    {
        public float rudder;
    };
    public struct TURN_struct
    {
        public float sideslip;
    };
}
