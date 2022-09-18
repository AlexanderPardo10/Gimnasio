using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Gym.App.Dominio;
using Gym.App.Persistencia;

namespace Gym.App.Presentacion.Pages

{
    public class CreateExerciseModel : PageModel
    {

         //La caracteristica [BindProperty] me permite incluir en este Modelo
        //[CCreateExerciseModel] y en la clase [Exercise]. Asó mismo con las validaciones
        //[Required] que se colocaron en la capa [Dominio] en la clase [Exercise]  
        [BindProperty]
        public Exercise exercise1 { get; set; }
        
        private readonly IRepositorioExercise _repoExercise;
        
        public void OnGet()
        {
        }

  
        public CreateExerciseModel(IRepositorioExercise repoExercise){
            //Inicializacion a la BD
            _repoExercise = repoExercise;
        }

        //La caracteristica [async] me permite tener el tiempo necesario
        //la conexion a la BD para transmitir los datos. Y me envia como
        //respuesta una accion.
        public async Task<IActionResult> OnPost(){
            if(!ModelState.IsValid){
                //Como la info no se ha ido, quedese en la pagina.
                return Page();
            }
            _repoExercise.createExercise(exercise1);
            return RedirectToPage("/Index");

        }
    }
}
