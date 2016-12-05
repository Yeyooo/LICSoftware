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
        LinkedList<String> premisa;
        String consecuente;

        public Clausula()
        {
            this.premisa = new LinkedList<String>();
        }

        public LinkedList<String> getPremisas()
        {
            return this.premisa;
        }

        public String getConsecuente()
        {
            return this.consecuente;
        }

        public void añadirPremisa(String premisa)
        {
            this.premisa.AddLast(premisa);
        }

        public void setConsecuente(String consecuente)
        {
            this.consecuente = consecuente;
        }

    }

    public class BaseDeConocimientos
    {
        LinkedList<Clausula> KB; // Lista de reglas

        public BaseDeConocimientos(String pathPre, String pathCon)
        {
            KB = new LinkedList<Clausula>();
            // Cargar desde Archivo

            try
            {

                if (File.Exists(pathPre) && File.Exists(pathCon))
                {
                    StreamReader readerPremisas = new StreamReader(pathPre);
                    StreamReader readerConsecuentes = new StreamReader(pathCon);
                    while (!readerPremisas.EndOfStream && !readerConsecuentes.EndOfStream)
                    {
                        String tmpPre = readerPremisas.ReadLine();

                        String[] spliteado = tmpPre.Split('-');

                        Clausula clausula = new Clausula();
                        foreach ( String simbolo in spliteado )
                        {
                            clausula.añadirPremisa(simbolo);
                        }
                        clausula.setConsecuente(readerConsecuentes.ReadLine());

                        KB.AddLast(clausula);

                    }

                    readerConsecuentes.Close();
                    readerPremisas.Close();

                    foreach ( Clausula clausula in KB )
                    {
                        foreach (String simbolo in clausula.getPremisas())
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

        public LinkedList<Clausula> getLista()
        {
            return this.KB;
        }

    }


    public class BaseDeHechos
    {
        LinkedList<String> hechos;
       
        public BaseDeHechos(String path)
        {
            hechos = new LinkedList<String>();
            // Cargar hechos, en nuestro caso, rendimiento del estudiante

            try
            {
                if (File.Exists(path))
                {
                    StreamReader reader = new StreamReader(path);
                    while (!reader.EndOfStream)
                    {
                        hechos.AddLast( reader.ReadLine() );
                    }

                    foreach(String hecho in hechos)
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

        public LinkedList<String> getListaDeHechos()
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
            if (EHD(kb, bh, "ana muere"))
            {
                Console.WriteLine("TRUE");
            }
            else { Console.WriteLine("FALSE"); }
        }

        public bool EHD(BaseDeConocimientos KB, BaseDeHechos BH, String hecho_a_probar) {

            Dictionary<int, int> cuenta = new Dictionary<int, int>(); //archivo con clausula y cantidad de hechos
            Dictionary<String, bool> inferido = new Dictionary<String, bool>(); //hechos a demostrar
            Queue<String> agenda = new Queue<string>(); //Cola de hechos //Base de hechos si simbolo = T entocnes agenda.agrega

            LinkedList<Clausula> x = KB.getLista();

            int nroClausula = 1;
            foreach(Clausula clausula in x)
            {
                int cantidad = 0;
                
                foreach(String simbolo in clausula.getPremisas())
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
                String premisa = agenda.Dequeue();
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
                        foreach (String simbolo in clausula.getPremisas()) {
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
