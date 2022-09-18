using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Gym.App.Persistencia; 
using Gym.App.Dominio;

namespace Gym.App.Presentacion.Pages
{
    public class ExerciseListModel : PageModel
    {
        //La sgte sentencia apunta hacioe el backend y realiza la
        //conexion a la BD.
        //[readonly] es una caracteristica de solo-lectura de la BD
        private readonly IRepositorioExercise _repoExercise;
        //Vamos a inicializar la variable [_repoCustomer] a traves del
        //constructor de la clase y con esto garantizamos la conexion a la
        //BD
        //En la lista [lstCustomer] almaceno la consulta
        public IEnumerable<Exercise> lstExercise {get; set;}     
        public ExerciseListModel(IRepositorioExercise repoExercise)
        {
            _repoExercise = repoExercise;

        } 

        public void OnGet()
        {
            //inicializo la lst vacia
            lstExercise = new List<Exercise>();
            lstExercise = _repoExercise.consultExercises();
        }
        //Como en la pagina [cshtml] tenemos dos metodos [post] una apunta a una
        //Consulta y la otra apunta a la Actualiacion del Cliente. 
        //Por eso utilizamos otro metodo [OnPost] y lo llamamos [OnPostEdit] 
        
        //creo un objeto del tipo exercise y lo llamo exercise 
        public Exercise exercise { get; set; }
        
        public async Task<IActionResult> OnPostEdit()
        {
            _repoExercise.deleteExercise(exercise.Id);
            if (exercise!= null)
            {
                return RedirectToPage("/ExerciseList");
            }
            return RedirectToPage("/Error");
        }

            //Como en la pagina [cshtml] tenemos dos metodos [post] una apunta a una
        //Consulta y la otra apunta a la Actualiacion del Cliente. 
        //Por eso utilizamos otro metodo [OnPost] y lo llamamos [OnPostEdit] 
        public async Task<IActionResult> OnPostDelete()
        {
            _repoExercise.deleteExercise(exercise.Id);
            if (exercise!= null)
            {
                return RedirectToPage("/ExerciseList");
            }
            return RedirectToPage("/Error");
        }
    }
}
