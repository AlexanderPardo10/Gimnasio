//Vamos a usar el paquete del sistema
using System;
//Definimos la capa a utilizar
namespace Gym.App.Dominio
{
    public class Customer{
//para cualquier cambio en la clase se DEBE ACTUALIZAR la base de datos y la conexión a la misma, para ello 
// primero de debe ir al repositorio de la clase e incluir las nuevas caracteristicas adicionadas a esta (en especial en el método "update")
// luego, hay que ejecutar En la CONSOLA, DENTRO DE LA CAPA DE PERSISTENCIA, los siguientes coMANdos (con las respectivas modificaciones):
// dotnet ef migrations add MigracionUno --startup-project ..\Gym.App.Presentacion\
// dotnet ef database update --startup-project ..\Gym.App.Presentacion\
//Por último (encaso de crear una base de datos nueva) crear la conexion desde la capa de presentación en el archivo "Starrtup.cs"
// con el comando: services.AddSingleton<IRepositorioExercise, RepositorioExercise>();

        //Definimos la funcionalidad de Propiedades, usando la
        //notacion Pascal (1mer caracter del atributo en Mayuscula).
        public int Id {get; set;}
        public string Name {get; set;} 
        public string Surname {get; set;}
        public int Age {get; set;}
        public string Telephone {get; set;}
        public string Address {get; set;} 
        public string Dni {get; set;} 
        //Definimos las relaciones de ASOCIACION
        //Clase Customer --> Credential 
        public Credential Credential {get; set;}
        public Gender Genero {get; set;}
        public Routine RoutineExercise {get; set;}
        //Clase  Customer --> Tracking
        public Tracking Tracking {get; set;}
        //Clase  Customer --> Nutrition
        public Nutrition Nutrition {get; set;}
        //Clase  Customer --> Value
        public Nutrition Value {get; set;}
        //Clase  Customer --> Routine
        public Nutrition Routine {get; set;}
        
    } 
}    