using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFSConnector
{
    public enum DEFINITION
    {
        Dummy = 0
    };
    public enum REQUEST
    {
        Dummy = 0
    };
    public class SimvarRequest
    {
        public DEFINITION eDef = DEFINITION.Dummy;
        public REQUEST eRequest = REQUEST.Dummy;

        public SimvarRequest(SimVar variable, DEFINITION eDef, REQUEST eRequest)
        {
            this.Variable = variable;
            this.eDef = eDef;
            this.eRequest = eRequest;
        }

        public SimVar Variable { get; private set; }

        public double dValue { get; set; } = 0.0;


        public double previousValue { get; set; } = 0.0;
    };
}
