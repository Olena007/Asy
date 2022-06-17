using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asy.Models
{
    internal class Tasks
    {
        private string _hello;
        private string _world;

        public async Task<string> Hello() 
        {
            using (StreamReader reader = new StreamReader(@"hello.txt"))
            {
                this._hello = await reader.ReadToEndAsync();
            }

            
            return this._hello;
        }

        public async Task<string> World()
        {
            using (StreamReader reader = new StreamReader(@"world.txt"))
            {
                this._world = await reader.ReadToEndAsync();
            }

            return this._world;
        }

        public async Task<string> Both()
        {
            string res = "";

            await Task.Run( async() =>
            {
                await Hello();
                await World();

                res = _hello + " " + _world;

                Console.WriteLine(res);
            }
                );
            return res;
        }
    }
}
