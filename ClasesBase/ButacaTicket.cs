using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class ButacaTicket
    {
        private int but_ID;
        private int nroButacaBtn;

        public int NroButacaBtn
        {
            get { return nroButacaBtn; }
            set { nroButacaBtn = value; }
        }

        public int But_ID
        {
            get { return but_ID; }
            set { but_ID = value; }
        }

        public ButacaTicket(int but_id, int nroBoton)
        {
            But_ID = but_id;
            NroButacaBtn = nroBoton;
        }
    }
}
