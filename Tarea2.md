# Tarea 2  

## **Unidad 2. Clases y Objetos**

***
### **Lee y escribe un resumen con tus palabras**

### *Clases y estructuras (Guía de programación de C#)*

### Las clases (class) y estructuras (struct) son básicamente una estructura de datos que encapsula un conjunto de datos y comportamientos que forman un conjunto para un programa.

### Una clase es un tipo de referencia. Cuando se crea un objeto de la clase, la variable a la que se asigna el objeto contiene solo una referencia a esa memoria. Una estructura es un tipo de valor. Cuando se crea una estructura, la variable a la que se asigna la estructura contiene los datos reales de ella. La diferencia entre ambas es que, mientras que la clase, al crear objeto, la variable que se le asigna al objeto, se vera reflejada en las demas variables, mientras que en la estructura, la variable original es independiente de las otras copias que referencien de la misma, por lo que no sufrira cambios.

### *Encapsulación*

### Según el principio de encapsulación, una clase o una estructura pueden especificar hasta qué punto se puede acceder a sus miembros para codificar fuera de la clase o la estructura.

### *Miembros*

### Todos los métodos, campos, constantes, propiedades y eventos deben declararse dentro de un tipo; se les denomina miembros del tipo.Por mencionar algunos, estan los campos constantes, propiedades, métodos, constructores, eventos, finalizadores, indizadores, operadores, tipos anidados.

### *Accesibilidad*

### La accesibilidad indica, valga la redundancia, que tan accesible será un metodo o propiedad, de manera que estos puedan o no puedan ser utilizados fuera de sus clases o estructuras.

### *Herencia*

### La herencia se aplica cuando una clase es creada tomando como base a otra clase, tomando asi los metodos y propiedades pertenecientes a la clase base (solo si estos son publicos o protegidos).

### *Interfaces*

### Las clases y las estructuras pueden heredar varias interfaces. Heredar de una interfaz significa que el tipo implementa todos los métodos definidos en la interfaz.

### *Tipos genéricos*

### Las clases y estructuras pueden definirse con uno o varios parámetros de tipo. El código de cliente proporciona el tipo cuando crea una instancia del tipo.

### *Tipos estáticos*

### Una clase estática puede contener solo miembros estáticos, y de estos no se pueden crear instancias de los mismo con new.

### *Tipos anidados*

### Una clase o estructura se puede anidar dentro de otra clase o estructura.

### *Tipos parciales*

###  Puede definir parte de una clase, estructura o método en un archivo de código y otra parte en un archivo de código independiente.

### *Inicializadores de objeto*

###  Puede crear instancias de objetos de clase o estructura y de colecciones de objetos e iniciarlizarlos, sin necesidad de llamar explicitamente a su constructor.

### *Tipos anónimos*

### Se usa cuando no es necesario crear una clase con un nombre en especifico.

### *Métodos de extensión*

### En vez de crear una clase derivada, esta se puede extender creando un tipo independiente, donde los metodos pueden llamarse como en la original.

### *Variables locales con asignación implícita de tipos*

### Dentro de un método de clase o estructura, puede utilizar tipos implícitos para indicar al compilador que determine el tipo correcto en tiempo de compilación.

***

## **Investiga sobre el operador new visto en clase. Describe algunos de sus usos.**

### El operador new puede utilizarse tanto como operador, modificador o una restricción.

### Como operador, funciona para crear objetos y mandar a llamar constructores.

### Como modificador, funciona para ocultar un miembro heredado de una clase base

### Como restricción, se usa para restringir tipos que pueden usarse como argumentos para un parámetro de tipo en una declaración genérica.

***
### **Escribe un programa donde utilices this para obtener acceso a miembros con el fin de evitar ambigüedades con nombres similares**

### 
    public Persona (string nombre, int e)
        {
            this.nombre=nombre;
            this.edad=e;
        }

### **Escribe un programa donde se utilice this como parámetro**

###
    public void Imprimir_promedio()
    {   
    Console.WriteLine("Promedio: {0:C}", Promedio.Calcpromedio(this));
    }
***
### **Lee y escribe un resumen con tus palabras**

### Los parámetros declarados para un método sin in, ref o out se pasan al método llamado por valor. Al querer cambiar el valor, este cambio se dejará de tomar en cuenta cuando se devuelva el control al procedimiento que hizo la llamada.

### **params** indica que el parametro puede tomar un numero x de argumentos. Puede enviar una lista separada por comas de argumentos del tipo especificado en la declaración de parámetro o una matriz de argumentos del tipo especificado. También puede no enviar ningún argumento. Si no envía ningún argumento, la longitud de la lista params se hará 0.

### Al usar params, no se permite usar otro tipo de parametros, y esta solo se puede usar una vez, ademas de que la matriz del tipo declarado debe ser unidimensional, o marcará error.

### **in** indica que el parametro es por referencia y puede ser leido por el método al que se llamo.

### **ref** indica que el parametro se pasa por referencia y puede ser leido o escrito por el método al que se llamo.

### Esta palabra clave se puede usar en cuatro contextos diferentes, los cuales son:

### **1**: En una firma del método y en una llamada al método, para pasar un argumento a un método mediante referencia.

### **2**: En una firma del método, para devolver un valor al autor de la llamada mediante referencia.

### **3**: En un cuerpo de miembro, para indicar que un valor devuelto de referencia se almacena localmente como una referencia que el autor de la llamada pretende modificar o, en general, que una variable local accede a otro valor por referencia.

### **4**: En una declaración struct, para declarar ref struct o ref readonly struct.

### **out** indica que el parametro se pasa por referencia y es escrito por el metodo al que se llamo.

### Esta palabra clave puede usarse como un modificador de parámetro, que le permite para un argumento a un metodo, usando una referencia en vez de un valor, y en declaraciones de parámetro de tipo genérico, que se usa en interfaces y delegados para especificar que un parámetro de tipo es covariante.

***

### **Lee y escribe un resumen con tus palabras**

### Los constructores son métodos de clase que se ejecutan cuando se crea un objeto. Estos tienen el mismo nombre que la clase, y normalmente inicializan los miembros de datos del objeto nuevo. Un constructor que no toma ningún parámetro se denomina constructor predeterminado. Los constructores predeterminados se invocan cada vez que se crea una instancia de un objeto mediante el operador new y no se proporciona ningún argumento a new.

### Los constructores para los tipos struct son parecidos a los de clases, solo que estos ya vienen con un constructor explicito generado automaticamente, por lo que no puede contener otro. Sin embargo, este constructor predeterminado sólo se invoca si se crean instancias del tipo struct con new.

### Tanto las clases como las structs pueden definir constructores que acepten parámetros. Se debe llamar a constructores que toman parámetros a través de una instrucción new o base.

### Un constructor puede invocar a otro constructor en el mismo objeto mediante la palabra clave this. Al igual que base, this se puede utilizar con o sin parámetros y cualquier parámetro en el constructor está disponible como parámetro para this o como parte de una expresión

### Los constructores se pueden marcar como public, private, protected, internal o protectedinternal. Estos modificadores de acceso definen cómo los usuarios de la clase pueden construir la clase. Un constructor se puede declarar como estático mediante la palabra clave static. Se llama automáticamente a los constructores estáticos de forma inmediatay, generalmente, se utilizan para inicializar los miembros de clase estáticos.

***

### **Implementa una clase llamada Dado**

 using System;

namespace dados
{
    class Dado 
    {
        public int valor;
        public string color;

public Dado (int valor, string color)
{
    this.valor = valor;
    this.color = color;
}
         public void Imprime()
        {
            Console.WriteLine(valor.ToString());
            Console.WriteLine(color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dado dado1 = new Dado(5,"verde");
            Dado dado2 = new Dado(3,"azul");
            Dado dado3 = new Dado(1,"rojo");
            dado1.Imprime();
        }
    }
}
