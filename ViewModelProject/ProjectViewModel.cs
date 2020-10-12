using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine.ViewModelProject
{
    //un viewmodel es una clase que no se registra en la datacontext
    public class ProjectViewModel//al final de la clase que se va a clonar se pone viewmodel 
    {
        //Por ejemplo esta es la clonacion de la clase project
        //Ponemos los datos que necesitamos 
        //como no se registra en la bd no lleva un key
        
        public int Id { get; set; }
        public string PName { get; set; }
        public string ProjectNo { get; set; }
        public string Contractor { get; set; }
        public string Supplier { get; set; }
        public string GeoSynthetic { get; set; }
        public string  Client { get; set; }

        
    }
}
