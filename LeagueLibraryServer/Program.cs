using LOLDotNet.LeagueDataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOLDotNet.LeagueLibraryServer
{
    public class Program
    {
        DataController instanceDataController = DataController.DEFAULT;

        static void Main(string[] args)
        {
            Application.Run(new Form1());

        }
    }
}
