using LOLDotNet.LeagueDataModel;
using LOLDotNet.LeagueDataModel.Inferfaces;
using LOLDotNet.LeagueDataModel.LeagueEntityObjects;
using LOLDotNet.LeagueLibraryServer.Services;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LOLDotNet.LeagueLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly.GetExecutingAssembly().GetManifestResourceStream("JsMath.js");
            //var compiler = new Microsoft.JScript.JScriptCodeProvider();
            //var parameters = new CompilerParameters(new[] { "/t:library" });
            //var result = compiler.CompileAssemblyFromSource(parameters, Properties.Resources.main);
            //var assembly = result.CompiledAssembly;
            
            //var url = 'http://ddragon.leagueoflegends.com/cdn/' + version + '/data/' + locale + '/item.json';
            //DataController.DEFAULT.Champions

            //foreach(var champ in DataController.DEFAULT.ChampionCollection.Champions)
            //{
            //    Console.Write(champ.Id + ":");
            //    Console.Write(champ.ChampionDetails.Name + ":");
            //    Console.WriteLine(champ.ChampionDetails.Title);
            //}
            IChampionService champService = new ChampionService();
            ChampionCollection championCollection = champService.GetChampionCollection();
            //foreach(Champion champ in champs.Champions)
            //{
            //    Console.WriteLine(champ.Id);
            //}
            //foreach(var champion in champs)
            //{
            Console.WriteLine(championCollection.Format);
            Console.WriteLine(championCollection.Type);
            Console.WriteLine(championCollection.Version);
            foreach(var key in championCollection.Keys)
            {

                Console.WriteLine(key);
            }
            foreach(Champion champ in championCollection.Champions.Values)
            {
                if (champ.AllyTips != null)
                {
                    //foreach (var tip in champ.AllyTips)
                      //  Console.WriteLine(tip);
                }
            }
            //}
            //System.Windows.Forms.Application.Run(new LeagueLibraryDashboard(championCollection));

            ItemCollection itemCollection = champService.GetItemCollection();

            //Item i = itemCollection.Data.Values.FirstOrDefault();
            foreach(var item in itemCollection.Data.Values)
            if(item != null)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey(true);
        }
    }
}
