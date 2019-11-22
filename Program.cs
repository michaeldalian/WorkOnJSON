using System;
using System.Collections.Generic;
using System.IO;

namespace WorkOnJSON
{

    class Program
    {
        /// <summary>
        /// Statrup method
        /// </summary>
        static void Main()
        {

            SerializeJson();

            deSerializeJson();

            /// <summary>
            /// Test d'écriture dans un JSON
            /// </summary>
            void SerializeJson()
            {
                string path = @Directory.GetCurrentDirectory() + @"\Output\dvd.json";

                Dvd _dvd = new Dvd(1, "ta mère");

                List<object> objets = new List<object>();

                objets.Add(_dvd);
                objets.Add(new Dvd(2, "et moi"));

                // JSONEdit.WriteCollectionToJSON(objets, path);
                JSONEdit.WriteObjectToJSON(_dvd, path);


            }

            /// <summary>
            /// Test de lecture d'un JSON
            /// </summary>
            void deSerializeJson()
            {
                string path = @Directory.GetCurrentDirectory() + @"\Output\dvd.json";

                Dvd _dvd = new Dvd(1, "ta mère");

                List<object> objets = new List<object>();

                objets.Add(_dvd);
                objets.Add(new Dvd(2, "et moi"));

                // JSONEdit.WriteCollectionToJSON(objets, path);

                System.Text.Json.JsonElement _dvd1 = JSONEdit.WriteJSONFileToJsonElement(path).Result;

                Console.WriteLine("Json content: {0}", _dvd1);

                // _dvd1.

                // _dvd = JSONEdit.WriteJSONFileToObject(path);

                // _dvd = await eggsTask;




            }

        }
    }


}





