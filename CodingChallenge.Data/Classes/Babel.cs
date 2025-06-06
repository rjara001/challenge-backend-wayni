using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CodingChallenge.Data.Classes
{
    public class Babel
    {
        private Dictionary<string, string> translations;

        public Babel(TipoIdioma TipoIdioma) {
            this.tipoIdioma = TipoIdioma;
        }

        public TipoIdioma tipoIdioma { get; set; }

        internal void Cargar()
        {
            // Aquí podrías cargar recursos específicos del idioma, como archivos de traducción o configuraciones.
            // Supongamos que tienes un archivo JSON llamado "translations.json" con el siguiente formato:
            // {
            //   "hello": "hola",
            //   "world": "mundo"
            // }
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var localsDirectory = System.IO.Path.Combine(baseDirectory, "Locals");
            if (!System.IO.Directory.Exists(localsDirectory))
                throw new System.IO.DirectoryNotFoundException($"No se encontró el directorio de locales: {localsDirectory}");

            var fileName = $"{tipoIdioma.ToString().ToLower()}.json";

            var filePath = System.IO.Path.Combine(localsDirectory, fileName);
            
            if (!System.IO.File.Exists(filePath))
                throw new System.IO.FileNotFoundException($"No se encontró el archivo de traducciones: {filePath}");

            var json = System.IO.File.ReadAllText(filePath);

            this.translations = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        internal string echo(string text)
        {
            if (this.translations.ContainsKey(text))
            {
                var value = this.translations[text];

                return value;
            }

            return text;
        }
    }
}