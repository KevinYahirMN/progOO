# Tarea 4

## **Unidad 4. Polimorfismo**

***
### 1. Considera el siguiente fragmento de programa:

    class A

    {

        public int a;
        public A()
        {
            a = 10;
        }

        public _______ string Display()

        {
            return a.ToString();
        }

    }

    class B:A

    {
        public int b;
        public B():base()

        {
             b = 15;
        }

        // #########################################

        //  #  Después de contestar la pregunta 1

        //   #  Redefine el método Display( ) en este espacio,  debe regresar el campo b como string.

        //  #########################################

    }

    class Program

    {
        public static void Main()
        {

            A objA = new A();

            B objB = new B();

            Console.WriteLine(objA.Display()); ////  (1 )

            Console. WriteLine(objB.Display()); ////  ( 2)

         }
    }

### 1.1. ¿Qué valores imprimen las lineas (1) y (2) ?

#### El valor del objeto A repetidamente

***

### 1.2.  Redefine el método Display en el espacio indicado

    class A

    {

        public int a;

        public A()

        {

            a = 10;
        }

        public virtual string Display()

        {
            return a.ToString();
        }
    }

    class B:A

    {
        public int b;

        public B():base()
        {
            b = 15;
        }

        public override string Display()
        {
            return b.ToString();
        }
    }

    class Program
    {
        public static void Main()
        {

            A objA = new A();

            B objB = new B();

            Console.WriteLine(objA.Display()); ////  (1 )

            Console. WriteLine(objB.Display()); ////  ( 2)
        }
    }

### una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2) ?

#### Los valores de los objetos A y B respectivamente.

***
### 1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?

#### Virtual

***

### 2. Considera el siguiente fragmento de programa:

    class Musico

    {

    public string nombre;

    public Musico (string n)

        {

         nombre = n;

        }

    public abstract (A) void Afina();  (B)

    public (C) string Display()

      {

       return nombre;

      }
     }

    class Bajista; Musico

    {

    public string instrumento;

    public Bajista (string n, string i ) ......

    .........

    public _________ Afina()

      {

      ________________

      }
    }

    class Guitarrista ____________

     {

     public instrumento;

      // Falta el constructor y otras cosas??


     }

    class Program

    {

        public static Main()

        {

            Musico m = new Musico("Django"); (D)

            Bajista b = new Bajista("Flea");

            Guitarrista g = new Guitarrista("Santana");

            Musico [] m = ____________________

            m[0] = b;

            m[1] = g;

            foreach ( ___________)

             _____________________

            Console.ReadKey();

        }

    }

### 2.1. Completa el programa

    abstract class Musico
    {
        public string nombre;
        public Musico (string n)

        {
          nombre = n;
        }
      public abstract void Afina();
      public string Display()

        {
          return nombre;
        }
    }

    class Bajista: Musico

    {
        public string instrumento;
        public Bajista (string n, string i ):base(n)
        {
            this.nombre = n;
            this.instrumento = i;
        }
        public override void Afina()
        {
          Console.WriteLine("El bajista {0} afina su bajo {1}",nombre, instrumento);
        }
    }

    class Guitarrista:Musico
    {
        public string instrumento;
        public Guitarrista (string n, string i ):base(n)
        {
          this.nombre = n;
          this.instrumento = i;
        }
        public override void Afina()
        {
          Console.WriteLine("El guitarrista {0} afina su guitarra {1}",nombre, instrumento);
        }
    }

    class Program
    {
        public static void Main()
        {

          Bajista b = new Bajista("Flea","generico");
          Guitarrista g = new Guitarrista("Santana","de lolo");

          List<Musico> musicos = new List<Musico>();
          musicos.Add(b);
          musicos.Add(g);
          foreach ( Musico x in musicos)
          x.Afina();
          Console.ReadKey();
        }
    }

***

### 2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?

#### (D) Debido a que no se pueden crear objetos en base a clases a bases abstractas

***

### 2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?

#### El metodo Afina, debido a que todas las clases que hereden de una clase madre, tienen por norma implementar todo lo de dicha clase.

***

### 2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?

#### Debido a que es el metodo base, y este sera modificado solamente en la clases que hereden este mismo.

#### Cuando lo implemente una clase que herede de la clase base.

***

### 2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?

#### Marcará error el metodo Afina, debido a que, al no ser abstracto, este necesitará de un cuerpo.

***

### 3. Implementa el programa utilizando interfaces en lugar de herencia

    interface IAfina
    {
        void Afina();
    }

    class Bajista: IAfina
    {
    public string instrumento;
    public string nombre;
    public Bajista (string n, string i )
    {
        this.nombre = n;
        this.instrumento = i;
    }
    public void Afina()
    {
        Console.WriteLine("El bajista {0} afina su bajo {1}",nombre, instrumento);
    }
    }

    class Guitarrista:IAfina
    {
        public string instrumento;
        public string nombre;
        public Guitarrista (string n, string i)
        {
            this.nombre = n;
            this.instrumento = i;
        }
        public void Afina()
        {
            Console.WriteLine("El guitarrista {0} afina su guitarra {1}",nombre, instrumento);
        }
    }

    class Program
    {
        public static void Main()
        {

          Bajista b = new Bajista("Flea","generico");
          Guitarrista g = new Guitarrista("Santana","de lolo");

          List<IAfina> musicos = new List<IAfina>();
          musicos.Add(b);
          musicos.Add(g);

          foreach ( IAfina x in musicos)
          x.Afina();
          Console.ReadKey();
        }
    }