using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App10.Test
{
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Età { get; set; }
    }
}
