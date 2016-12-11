using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Interfaz_Fixed
{
    public partial class Material_ApoyoAudio : Form
    {

        public Material_ApoyoAudio(string path)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = path;
        }

    }
}
