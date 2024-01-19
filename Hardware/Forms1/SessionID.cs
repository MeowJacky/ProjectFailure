using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SessionID
{
    private static SessionID instance;

    private string ID;
    private int Authority = 999;

    private SessionID() { }

    public static SessionID Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SessionID();
            }
            return instance;
        }
    }

    // Public method to set the RFID value
    public string SetID(string IDString, int UserAuthority = 999)
    {
        ID = IDString;
        if (UserAuthority != 999)
        {
            Authority = UserAuthority;
        }
        else
        {
            Authority = 999;
        }
        return ID;
    }

    // Public method to retrieve the RFID value
    public string RetrieveID()
    {
        return ID;
    }

    public int RetrieveAuthority()
    {
        return Authority;
    }
}

