//Vamos a usar el paquete del sistema
using System;
//Definimos la capa a utilizar
namespace Gym.App.Dominio
{
    public class Exercise{
        //Definimos la funcionalidad de Propiedades, usando la
        //notacion Pascal (1mer caracter del atributo en Mayuscula).
        public int Id {get; set;}      
        public int ConsecutivoIntensidad {get; set;}
        public string Name {get; set;}  
        public int TiempoDedidado {get; set;}
        public string ExerciseConditions {get; set;}
        public int ConsumedCalories {get; set;}
        public string UrlExercise {get; set;}

        //Definimos las relaciones de ASOCIACION
        //Clase Customer --> Credential 
        public BodyPart BodyPart {get; set;}
        public Intensity Intensity {get;set;}
    }
}