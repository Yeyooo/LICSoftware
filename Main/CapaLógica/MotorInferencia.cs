using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{

    //Clase exclusiva para funciones del motor de inferencia.
    public class MotorInferencia
    {
        

<<<<<<< HEAD
        función ENCADENAMIENTO-HACIA-DELANTE(KB, c)
        devuelve T o F
            # Nº de símbolos en cada cláusula.
            cuenta ← CREAR-DICCIONARIO()
            # Si un símbolo ha sido inferido ya.
            inferido ← CREAR-DICCIONARIO()
            # Símbolos que se sabe que son verdaderos.
            agenda ← CREAR-FIFO()
            por cada cláusula en KB hacer
                cantidad ← 0
                por cada símbolo en cláusula.PREMISA hacer
                    cantidad = cantidad + 1
                    inferido[símbolo] = F
                    si símbolo = T entonces agenda.AGREGAR(símbolo)
                cuenta[cláusula] ← cantidad

            mientras no agenda.ESTÁ-VACÍA() hacer
                p ← agenda.POP()
                si p = c entonces devolver T
                # Evitar repetir y bucles.
                si inferido[p] = F entonces
                    inferido[p] ← T
                    por cada cláusula en KB hacer
                        si p está en cláusula.PREMISA hacer
                            cuenta[cláusula] ← cuenta[cláusula] – 1
                            si cuenta[cláusula] = 0 entonces
                                agenda.AGREGAR(cláusula.CONCLUSIÓN)
            devolver F
=======
>>>>>>> origin/master
    }

}
