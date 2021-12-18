Resumen = https://drive.google.com/drive/folders/1JsDP_xs1SaS_fGIKHTCohR5zLamusxaU?usp=sharing

Creacionales:

	Proveen diferentes formas de crear objetos
	Inicializa y configura objetos.
	Da soluciones a crear instancias concretas de ciertos objetos,
	ayuda a mantener el código libre de infinitos ifs o switches.
	

	Abstract Factory = Crea diferentes familias de objetos, logra escalabilidad a nivel familia.

	Builder = Separa la construcción de un objeto complejo de su representación, de forma que el mismo proceso de construcción pueda crear diferentes representaciones.
	
	Factory Method = Devolver instancias de una clase en particular, por medio de algún identificador.

	Prototype = Especifica los tipos de objetos a crear, por medio de una instancia prototipica y crea nuevos ojetos a partir de esta

	Singleton = Generar una unica instancia de un objeto, consumible por multiples clientes.



Estructurales:

	Separan la interfaz de la implementación.
	Define como las clases y objetos se agrupan para definir estructuras complejas.
	Configura las relaciones entre objetos.
	Describen formas de componer objetos para formar nuevas estructuras flexibles y eficientes
	
	Adapter = Convierte la interfaz de una clase en otra interfaz que es la que esperan los clientes.
		  Permite que cooperen las clases que de otra forma no podrian por tener interfaces incompatibles.

	Bridge = permite dividir una clase grande, o un grupo de clases estrechamente relacionadas,
		 en dos jerarquías separadas (abstracción e implementación) que pueden desarrollarse 
		 independientemente la una de la otra.[ Dispositivos, tv, equipo de musica, dvd] [Controles]

	Composite = Componer objetos en estructuras de árbol para representar jerarquías de parte-todo.
		    Permite que los clientes traten de manera uniforme a los objetos individuales y a los compuestos.


	Facade = ocultar o simplificar la complejidad que pueda tener la aplicación
		 El cliente utiliza la fachada para disponer de las implementaciones mediante este intermediario

	Facade = Facade o Fachada es un patron que busca ocultar o simplificar la logica de la aplicaicon,
		 El cliente dispone de las implementaciones gracias al mediador Facade.

	Flyweight = 


	Proxy = Crea un envoltorio que permita tener el acceso a el objeto real o final.
		Encapsula la complejidad del objetivo en un envoltorio,
		el cliente interactúa con el intermediario, y el intermediario delega la información.

	Decorator = Agregar funcionalidades a una clase existente, sin modificar su estructura,
		    sin tener que recurrir a la herencia. 
		    Es una alternativa flexible a la herencia para extender la funcionalidad.

	Proxy = Envoltorio que otorga el acceso a el objeto real o final.
		Encapsula la complejidad del objetivo, el cliente interactua con el intermediario,
		el intermediario delega la informacion.

	Decorator = Agrega funcionalidad a una clase existente, sin modificar su estructura.
		    Lo logra a partir de  crear una nueva clase.


Comportamiento:
	
	Describe cómo los objetos y clases están comunicados.
	Desacopla los comportamientos de los objetos, dando la opción de ser más varaibles.
	Gestionan algoritmos y responsabilidades entre objetos

	Chain Of Responsability = Evitar acoplar el emisor de una petición a su receptor, 
				  dando la posibilidad de responder a la petición a mas de un objeto.
				  Encadena los objetos y pasa la petición a través de la cadena 
				  hasta que se procesa por algún objeto.

	Command = Encapsula la petición de alguna operación bajo algún método.
        	  enfoque orientado a comandos, Crea una lista de ejecución de métodos.

	Interpreter = Dado un lenguaje, define una representación de su gramática junto con un interprete 
		      que usa dicha representación para interceptar sentencias del lenguaje.

	Command = Crea una lista de ejecucion de metodos. Enfoqueorientado a comandos
		  Utilizado con multihilos.

	Iterator =

	Mediator =

	Memento = Patron Memento, guarda el estado de una operación en un momento determinado
            	  Se utiliza para restablecer el estado de un objeto, como un rollback.

	Observer = El patrón observador se utilizará para notificar cambios de estado a un objeto.

	State =

	Memento = Guarda el estado de una operacion en un momento determinado,
		  Restaura el elemento al estado guardado anteriormente.

	Observer = Notifica los cambios de estado en un objeto,
		   Aplica la logica desarrollada en la implementacion del observer.

	Strategy = Tener diferentes algoritmos, diferentes lógicas encapsuladas.
		   Se pueden definir familias de algoritmos, encapsularlos y hacerlos intercambiables.
		   Los algoritmos serán independientes de los clientes que los están utilizando.

	Template Method =

	Visitor =

