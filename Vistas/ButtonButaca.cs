using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Vistas
{
    class ButtonButaca : Button
    {
        private int butacaId;
        public int ButacaId 
        {
            get { return butacaId; }
            set 
            {
                butacaId = value;
            }
        }
    }
}
