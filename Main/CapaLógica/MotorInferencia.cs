using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{

    public class Clausula
    {
        List<string> premisa;
        string consecuente;

        public Clausula()
        {
            this.premisa = new List<string>();
        }


        public List<string> getPremisas()
        {
            return this.premisa;
        }

        public string getConsecuente()
        {
            return this.consecuente;
        }

        public void añadirPremisa(string premisa)
        {
            this.premisa.Add(premisa);
        }

        public void setConsecuente(string consecuente)
        {
            this.consecuente = consecuente;
        }

    }

    public class BaseDeConocimientos
    {
        List<Clausula> KB; // Lista de reglas

        public BaseDeConocimientos(string pathPre, string pathCon)
        {
            KB = new List<Clausula>();
            // Cargar desde Archivo

            try
            {

                if (File.Exists(pathPre) && File.Exists(pathCon))
                {
                    StreamReader readerPremisas = new StreamReader(pathPre);
                    StreamReader readerConsecuentes = new StreamReader(pathCon);
                    while (!readerPremisas.EndOfStream && !readerConsecuentes.EndOfStream)
                    {
                        string tmpPre = readerPremisas.ReadLine();

                        string[] spliteado = tmpPre.Split('-');

                        Clausula clausula = new Clausula();
                        foreach ( string simbolo in spliteado )
                        {
                            clausula.añadirPremisa(simbolo);
                        }
                        clausula.setConsecuente(readerConsecuentes.ReadLine());

                        KB.Add(clausula);

                    }

                    readerConsecuentes.Close();
                    readerPremisas.Close();

                    foreach ( Clausula clausula in KB )
                    {
                        foreach (string simbolo in clausula.getPremisas())
                        {
                            Console.Write(" "+simbolo);
                        }
                        Console.WriteLine(" -> "+clausula.getConsecuente());
                    }

                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.ReadKey();
            }


        }

        public List<Clausula> getLista()
        {
            return this.KB;
        }

    }


    public class BaseDeHechos
    {
        public List<string> hechos;

        public BaseDeHechos() { this.hechos = new List<string>(); }
       
        public BaseDeHechos(string path)
        {
            hechos = new List<string>();
            // Cargar hechos, en nuestro caso, rendimiento del estudiante

            try
            {
                if (File.Exists(path))
                {
                    StreamReader reader = new StreamReader(path);
                    while (!reader.EndOfStream)
                    {
                        hechos.Add( reader.ReadLine() );
                    }

                    foreach(string hecho in hechos)
                    {
                        Console.WriteLine(hecho);
                    }
                    reader.Close();
                }
            }
            catch ( FileNotFoundException e )
            {
                Console.WriteLine(e.StackTrace);
                Console.ReadKey();
            }

            

        }

        public List<string> getListaDeHechos()
        {
            return this.hechos;
        }
    }


    //Clase exclusiva para funciones del motor de inferencia.
    public class MotorInferencia
    {
        public MotorInferencia()
        {
            BaseDeHechos bh = new BaseDeHechos(Environment.CurrentDirectory + "/bh.csv");
            BaseDeConocimientos kb = new BaseDeConocimientos(Environment.CurrentDirectory + "/kb.csv", Environment.CurrentDirectory + "/kb_consec.csv");
            if (EHD(kb, bh, "h"))
            {
                Console.WriteLine("TRUE");
            }
            else { Console.WriteLine("FALSE"); }
        }

        public static bool EHD(BaseDeConocimientos KB, BaseDeHechos BH, string hecho_a_probar) {

            Dictionary<int, int> cuenta = new Dictionary<int, int>(); //archivo con clausula y cantidad de hechos
            Dictionary<string, bool> inferido = new Dictionary<string, bool>(); //hechos a demostrar
            Queue<string> agenda = new Queue<string>(); //Cola de hechos //Base de hechos si simbolo = T entocnes agenda.agrega

            List<Clausula> x = KB.getLista();

            int nroClausula = 1;
            foreach(Clausula clausula in x)
            {
                int cantidad = 0;
                
                foreach(string simbolo in clausula.getPremisas())
                {
                    cantidad++;
                    inferido[simbolo] = false;
                    if (BH.getListaDeHechos().Contains(simbolo))
                    {
                        agenda.Enqueue(simbolo);
                    }
                    cuenta[nroClausula] = cantidad; // si no funciona, inicializar en 0.
                }
                nroClausula++;

            } // end of foreach

            

            while (agenda.Count() != 0)
            {
                string premisa = agenda.Dequeue();
                if( premisa.CompareTo( hecho_a_probar ) == 0)
                {
                    return true;
                }

                if (inferido[premisa] == false)
                {
                    inferido[premisa] = true;
                    int nro_Clausula = 1;
                    foreach ( Clausula clausula in x )
                    {
                        foreach (string simbolo in clausula.getPremisas()) {
                            if (premisa.CompareTo(simbolo) == 0)
                            {
                                cuenta[nro_Clausula] = cuenta[nro_Clausula] - 1;
                                if( cuenta[nro_Clausula] == 0)
                                {
                                    agenda.Enqueue(clausula.getConsecuente());
                                }
                            }
                        }
                        nro_Clausula++;

                    }
                }
            } // end of while

            return false;
            
        }
       
    }

}
