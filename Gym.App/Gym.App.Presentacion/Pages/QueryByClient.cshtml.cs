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
    public class QueryByClientModel : PageModel
    {

        private readonly IRepositorioCustomer _repoCustomer;
        [BindProperty]
        public Customer customer { get; set; }

        public QueryByClientModel(IRepositorioCustomer repoCustomer)
        {
            _repoCustomer = repoCustomer;
        }

        //public int Dni {get; set;} 
        public void OnGet()
        {
            customer = new Customer();
        }
        public async Task<IActionResult> OnPost()
        {
            customer = _repoCustomer.consultCustomerByDni(customer.Dni);
            if (customer == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }
        //Como en la pagina [cshtml] tenemos dos metodos [post] una apunta a una
        //Consulta y la otra apunta a la Actualiacion del Cliente. 
        //Por eso utilizamos otro metodo [OnPost] y lo llamamos [OnPostEdit] 
        public async Task<IActionResult> OnPostEdit()
        {
            customer = _repoCustomer.updateCustomer(customer);
            if (customer!= null)
            {
                return RedirectToPage("/QueryCustomers");
            }
            return RedirectToPage("/Error");
        }

    }
}
